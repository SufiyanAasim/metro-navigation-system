# Release Process

1. Merge all changes intended for the release into `main`.
2. Add an entry to [CHANGELOG.md](CHANGELOG.md) under a new version heading, following the existing `[vX.Y.Z] - YYYY-MM-DD ("Codename")` format.
3. If the release warrants a detailed write-up, add one under [docs/releases/](docs/releases/) and link it from [docs/releases/README.md](docs/releases/README.md).
4. Commit the changelog/docs update.
5. Tag the release and push the tag:
   ```bash
   git tag v1.2.0
   git push origin v1.2.0
   ```
6. Pushing a `v*` tag triggers [`.github/workflows/release.yml`](.github/workflows/release.yml), which builds the app, packages it via [`scripts/package-release.ps1`](scripts/package-release.ps1), and publishes a GitHub Release with the ZIP attached and `CHANGELOG.md` as the release body.
7. Verify the published release and download the asset to sanity-check it.

See [docs/deployment.md](docs/deployment.md) for details on manual packaging.
