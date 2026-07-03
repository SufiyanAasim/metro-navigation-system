# Building and Releasing

## Release builds

```bash
dotnet build "src/MetroApp/Metro App.csproj" -c Release
```

## Packaging a release ZIP

[`scripts/package-release.ps1`](../scripts/package-release.ps1) builds the app in Release mode, stages the executable, its config, and required runtime DLLs alongside `LICENSE`, `README.md`, and `CHANGELOG.md`, then compresses everything into `MetroNavigationSystem-v<version>.zip` at the repository root:

```powershell
./scripts/package-release.ps1 -Version "1.1.5"
```

The output zip is git-ignored — it is a build artifact, not a tracked file.

## Automated releases (CI)

[`.github/workflows/release.yml`](../.github/workflows/release.yml) triggers on any pushed tag matching `v*`:

1. Restores and builds `src/MetroApp/Metro App.csproj` in Release mode via MSBuild.
2. Runs `scripts/package-release.ps1` with the version extracted from the tag.
3. Publishes a GitHub Release with the resulting ZIP attached, using `CHANGELOG.md` as the release body.

To cut a release: update `CHANGELOG.md`, commit, tag (`git tag v1.2.0`), and push the tag (`git push origin v1.2.0`). See [RELEASE.md](../RELEASE.md) for the full process.

Every push and pull request against `main` also runs [`.github/workflows/ci.yml`](../.github/workflows/ci.yml), which restores and builds the project to catch compile errors early.
