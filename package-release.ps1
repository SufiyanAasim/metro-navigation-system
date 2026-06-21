# PowerShell script to package the release binaries into a ZIP file.
# Usage: .\package-release.ps1 -Version "1.0.0"

param (
    [string]$Version = "1.0.0"
)

$ErrorActionPreference = "Stop"

Write-Host "=============================================" -ForegroundColor Cyan
Write-Host "Packaging Metro Navigation System v$Version..." -ForegroundColor Cyan
Write-Host "=============================================" -ForegroundColor Cyan

# 1. Build the application in Release mode
Write-Host "Building project in Release mode..." -ForegroundColor Blue
dotnet build "Metro App.csproj" -c Release

$releaseBinDir = Join-Path $PSScriptRoot "bin\Release"
$exePath = Join-Path $releaseBinDir "Metro Navigation System.exe"

if (-not (Test-Path $exePath)) {
    throw "Build failed: Executable not found at $exePath"
}

# 2. Setup Staging Directory
$stageDir = Join-Path $PSScriptRoot "temp_release_stage"
if (Test-Path $stageDir) {
    Write-Host "Cleaning up old staging directory..." -ForegroundColor Yellow
    Remove-Item $stageDir -Recurse -Force
}
New-Item -ItemType Directory -Path $stageDir | Out-Null

# 3. Copy Files
Write-Host "Copying files to staging directory..." -ForegroundColor Blue
$filesToCopy = @(
    "$releaseBinDir\Metro Navigation System.exe",
    "$releaseBinDir\Metro Navigation System.exe.config",
    "$releaseBinDir\System.Formats.Nrbf.dll",
    "$releaseBinDir\System.Resources.Extensions.dll"
)

foreach ($file in $filesToCopy) {
    if (Test-Path $file) {
        Copy-Item -Path $file -Destination $stageDir
    } else {
        Write-Warning "Required file $file not found!"
    }
}

# Copy optional root documentation
$docs = @("LICENSE", "README.md", "RELEASE_NOTES.md")
foreach ($doc in $docs) {
    $docPath = Join-Path $PSScriptRoot $doc
    if (Test-Path $docPath) {
        Copy-Item -Path $docPath -Destination $stageDir
    }
}

# 4. Create ZIP archive
$zipName = "MetroNavigationSystem-v$Version.zip"
$zipPath = Join-Path $PSScriptRoot $zipName

if (Test-Path $zipPath) {
    Write-Host "Removing existing ZIP package..." -ForegroundColor Yellow
    Remove-Item $zipPath -Force
}

Write-Host "Compressing archive to $zipName..." -ForegroundColor Blue
Compress-Archive -Path "$stageDir\*" -DestinationPath $zipPath -Force

# 5. Clean up Staging Directory
Write-Host "Cleaning up staging directory..." -ForegroundColor Blue
Remove-Item $stageDir -Recurse -Force

Write-Host "=============================================" -ForegroundColor Green
Write-Host "Release package successfully created at:" -ForegroundColor Green
Write-Host "  $zipPath" -ForegroundColor Green
Write-Host "=============================================" -ForegroundColor Green
