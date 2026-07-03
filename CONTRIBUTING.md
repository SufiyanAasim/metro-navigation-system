# Contributing

Thanks for your interest in improving the Metro Navigation System.

## Getting started

See [docs/development.md](docs/development.md) for environment setup and build instructions.

## Workflow

1. Fork the repository and create a branch off `main`.
2. Make your changes under `src/MetroApp/`.
3. Verify the project builds: `dotnet build "src/MetroApp/Metro App.csproj" -c Release`.
4. Manually exercise the affected screens — there is currently no automated UI test suite (see [tests/README.md](tests/README.md)).
5. Update `CHANGELOG.md` for any user-facing change, and relevant files under `docs/` if behavior or structure changed.
6. Open a pull request using the provided template.

## Code style

Follow the existing WinForms conventions in the codebase (designer-generated layout in `*.Designer.cs`, event handlers and logic in the paired `*.cs` file). An [.editorconfig](.editorconfig) is provided for basic formatting rules.

## Reporting bugs and requesting features

Please use the issue templates under [.github/ISSUE_TEMPLATE](.github/ISSUE_TEMPLATE).

## Maintainers

- **Mohammad Sufiyan Aasim** — System Architect · AI/MLOps · Docs — [@SufiyanAasim](https://github.com/SufiyanAasim)
- **Fahad Bin Nasir** — Front-end Development — [@FahadBinNasir](https://github.com/FahadBinNasir)
