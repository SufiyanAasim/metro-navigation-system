# Release Process

This document describes how to cut a new release of Metro Navigation System.

---

## 1. Decide version and codename

Use [Semantic Versioning](https://semver.org/):

| Change type | Bump |
|-------------|------|
| Breaking change | MAJOR |
| New feature | MINOR |
| Bug fix only | PATCH |

Codenames follow a single consistent theme across all releases.

Format:
```
v1.2.0
Codename: <Name>
```

---

## 2. Update version references

Update the version string in:
- `src/MetroApp/Properties/AssemblyInfo.cs` — `AssemblyVersion` and `AssemblyFileVersion`
- `README.md` — version badge
- `CHANGELOG.md` — new section header and footer reference link

---

## 3. Write the changelog entry

Add a new section to `CHANGELOG.md` following the [Keep a Changelog](https://keepachangelog.com/) format:

```markdown
## [1.2.0] — "Codename" — YYYY-MM-DD

### Added
### Changed
### Fixed
### Removed
```

---

## 4. Write the release doc

Create `docs/releases/v1.2.0.md` using any existing release file as a template. Include: codename, overview, categorized change list, architecture progress notes, and a compatibility table.

---

## 5. Verify the build

```bash
dotnet build "src/MetroApp/Metro App.csproj" -c Release
```

The build must succeed before tagging.

---

## 6. Commit and tag

```bash
git add -A
git commit -m "release: v1.2.0 - Codename"
git tag v1.2.0
git push origin main --tags
```

Include co-authors in the commit message if applicable:
```
release: v1.2.0 - Codename

Co-authored-by: Contributor Name <their-github-registered-email@example.com>
```

---

## 7. GitHub release

Pushing a `v*` tag triggers [`.github/workflows/release.yml`](.github/workflows/release.yml), which builds the app, packages it via [`scripts/package-release.ps1`](scripts/package-release.ps1), and publishes a GitHub Release with the ZIP attached and `CHANGELOG.md` as the release body.

To verify: navigate to the GitHub Releases page, confirm the executable is attached, and download it to sanity-check the packaged build.

---

## 8. Update ROADMAP.md

Mark the shipped version as ✅ Shipped and promote the next planned version.
