# PowerShell script to tag commits, push tags, create GitHub releases and upload local ZIP assets.
# Usage: .\scripts\publish-releases.ps1

param (
    [Parameter(Mandatory=$false)]
    [string]$GitHubToken
)

$ErrorActionPreference = "Stop"

# Get repository root
$repoRoot = Resolve-Path (Join-Path $PSScriptRoot "..")
$owner = "SufiyanAasim"
$repo = "metro-navigation-system"

# Ensure we are in git repository
if (-not (Test-Path (Join-Path $repoRoot ".git"))) {
    throw "Not in a git repository!"
}

# Prompt for Token if not provided
if (-not $GitHubToken) {
    $GitHubToken = Read-Host -Prompt "Enter your GitHub Personal Access Token (PAT)"
    if ([string]::IsNullOrWhiteSpace($GitHubToken)) {
        throw "GitHub Token is required."
    }
}

# Define releases metadata mapping (Chronological Order: oldest to newest)
$releases = @(
    @{
        Version = "v1.0.0"
        Commit = "13685da4093a4428ab95b33ece3af4740f7f1211"
        Codename = "Magenta"
        ZipName = "MetroNavigationSystem-v1.0.0.zip"
        DocFile = "docs/releases/v1.0.0.md"
        Prerelease = $true
    },
    @{
        Version = "v1.0.5"
        Commit = "1c630c2541c079b04957bde16c69c75fef819091"
        Codename = "Neon"
        ZipName = "MetroNavigationSystem-v1.0.5.zip"
        DocFile = "docs/releases/v1.0.5.md"
        Prerelease = $false
    },
    @{
        Version = "v1.1.0"
        Commit = "0734416c35e78e4c8994c1a77a1ffa64ca3d011e"
        Codename = "Crimson"
        ZipName = "MetroNavigationSystem-v1.1.0.zip"
        DocFile = "docs/releases/v1.1.0.md"
        Prerelease = $false
    },
    @{
        Version = "v1.1.5"
        Commit = "3c04645447447daac85ae130b2b12fae76520ded"
        Codename = "Teal"
        ZipName = "MetroNavigationSystem-v1.1.5.zip"
        DocFile = "docs/releases/v1.1.5.md"
        Prerelease = $false
    }
)

# Common headers for GitHub API
$headers = @{
    "Authorization" = "token $GitHubToken"
    "Accept"        = "application/vnd.github.v3+json"
    "User-Agent"    = "PowerShell-Release-Publisher"
}

Write-Host "=============================================" -ForegroundColor Cyan
Write-Host "Re-publishing GitHub Releases Chronologically..." -ForegroundColor Cyan
Write-Host "=============================================" -ForegroundColor Cyan

# 1. First, delete all existing releases to ensure correct chronological sorting
Write-Host "`nStep 1: Clearing existing releases from GitHub..." -ForegroundColor Yellow
foreach ($rel in $releases) {
    $v = $rel.Version
    $releaseUrl = "https://api.github.com/repos/$owner/$repo/releases/tags/$v"
    try {
        $existing = Invoke-RestMethod -Uri $releaseUrl -Method Get -Headers $headers
        if ($existing) {
            Write-Host "   Deleting release $v (ID: $($existing.id))..." -ForegroundColor Red
            $deleteUrl = "https://api.github.com/repos/$owner/$repo/releases/$($existing.id)"
            Invoke-RestMethod -Uri $deleteUrl -Method Delete -Headers $headers | Out-Null
        }
    } catch {
        # Ignore 404s
        if ($_.Exception.Response.StatusCode.value__ -ne 404) {
            Write-Warning "Failed to check/delete release ${v}: $_"
        }
    }
}

# 2. Re-create and publish releases one by one in chronological order
Write-Host "`nStep 2: Creating releases in chronological order..." -ForegroundColor Yellow

for ($i = 0; $i -lt $releases.Count; $i++) {
    $rel = $releases[$i]
    $v = $rel.Version
    $commit = $rel.Commit
    $codename = $rel.Codename
    $zipFile = Join-Path $repoRoot $rel.ZipName
    $docPath = Join-Path $repoRoot $rel.DocFile
    $isPrerelease = $rel.Prerelease

    Write-Host "`n--- Publishing Release $v ($codename) ---" -ForegroundColor Blue

    # Check local ZIP and notes
    if (-not (Test-Path $zipFile)) {
        throw "Required ZIP file not found: $zipFile"
    }
    if (-not (Test-Path $docPath)) {
        throw "Required Release Notes file not found: $docPath"
    }

    # Read release notes body (ensure UTF-8)
    $body = [string](Get-Content -Path $docPath -Raw -Encoding UTF8)

    # Tag validation and push
    $tagExistsLocally = git tag -l $v
    if (-not $tagExistsLocally) {
        Write-Host "   Creating tag $v at commit $commit..." -ForegroundColor Yellow
        git tag $v $commit
    }
    Write-Host "   Pushing tag $v to origin..." -ForegroundColor Yellow
    git push origin $v

    # Create release payload
    $releaseName = $v + " - " + $codename
    $releaseData = @{
        tag_name = $v
        target_commitish = $commit
        name = $releaseName
        body = $body
        draft = $false
        prerelease = $isPrerelease
    } | ConvertTo-Json

    # Create new Release
    Write-Host "   Creating release on GitHub..." -ForegroundColor Green
    $createUrl = "https://api.github.com/repos/$owner/$repo/releases"
    $release = Invoke-RestMethod -Uri $createUrl -Method Post -Headers $headers -Body $releaseData -ContentType "application/json; charset=utf-8"
    Write-Host "   Created release ID: $($release.id)" -ForegroundColor Green

    # Upload ZIP Asset
    Write-Host "   Uploading asset $($rel.ZipName)..." -ForegroundColor Green
    $uploadUrlTemplate = $release.upload_url
    $bracketIndex = $uploadUrlTemplate.IndexOf("{")
    $uploadUrl = $uploadUrlTemplate.Substring(0, $bracketIndex) + "?name=$($rel.ZipName)"

    $bytes = [System.IO.File]::ReadAllBytes($zipFile)
    $uploadResponse = Invoke-RestMethod -Uri $uploadUrl -Method Post -Headers $headers -Body $bytes -ContentType "application/zip"
    Write-Host "   Successfully uploaded $($rel.ZipName)." -ForegroundColor Green

    # Sleep for 5 seconds to ensure distinct chronological timestamps
    if ($i -lt ($releases.Count - 1)) {
        Write-Host "   Waiting 5 seconds before next release..." -ForegroundColor Gray
        Start-Sleep -Seconds 5
    }
}

Write-Host "`n=============================================" -ForegroundColor Green
Write-Host "All releases successfully re-published!" -ForegroundColor Green
Write-Host "=============================================" -ForegroundColor Green
