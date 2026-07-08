# Development

## Prerequisites

- Windows OS
- Visual Studio 2019 or later (or the .NET Framework 4.7.2 targeting pack + MSBuild for command-line builds)
- .NET Framework 4.7.2

## Setup

```bash
git clone https://github.com/SufiyanAasim/metro-navigation-system.git
cd metro-navigation-system
```

## Running from source

Open [`src/MetroApp/Metro App.csproj`](../src/MetroApp/Metro%20App.csproj) directly in Visual Studio — there is no solution file — and build/run with `F5`.

Or build from the command line:

```bash
dotnet build "src/MetroApp/Metro App.csproj" -c Release
```

The compiled executable is written to `src/MetroApp/bin/Release/Metro Navigation System.exe`.

## Running tests

There is no automated test suite yet. See [tests/README.md](../tests/README.md) for what's testable and how to add coverage.

## Project structure

```
metro-navigation-system/
├── src/
│   └── MetroApp/            # Application source
│       ├── Metro App.csproj
│       ├── Properties/      # Assembly and settings configuration
│       ├── Resources/        # UI backgrounds, icons, and button assets
│       ├── lib/               # Vendored reference assemblies
│       ├── MetroNetwork.cs   # Route engine (Dijkstra)
│       ├── TripHistoryService.cs
│       ├── FormNavigator.cs
│       └── ...                # Welcome/Choices/Map/Stations/ShortestPath/Receipt/Credits forms
├── tests/
│   └── README.md
├── docs/
│   ├── Architecture.md
│   ├── Database.md
│   ├── Development.md
│   ├── Troubleshooting.md
│   └── releases/
├── scripts/
│   └── package-release.ps1
├── .github/
└── main assembly + community-health files (LICENSE, CHANGELOG.md, etc.)
```

## Building the Windows executable

```powershell
./scripts/package-release.ps1 -Version "1.1.5"
```

Builds in Release mode and stages `Metro Navigation System.exe` plus its config, runtime DLLs, and docs into `MetroNavigationSystem-v1.1.5.zip` at the repository root. The output zip is git-ignored — it's a build artifact, not a tracked file.

## Commit convention

Follow [Conventional Commits](https://www.conventionalcommits.org/):

```
feat(receipt): add printable ticket flow
fix(stations): correct map marker highlighting
docs(readme): update project structure
refactor(network): extract path reconstruction helper
```

## Branch naming

```
main
feature/lan-free-route-cache
bugfix/receipt-print-crash
docs/api-reference
release/v1.2.0
hotfix/credits-version-label
```
