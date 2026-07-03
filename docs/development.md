# Development Setup

## Requirements

- Windows OS
- Visual Studio 2019 or later (or the .NET Framework 4.7.2 targeting pack + MSBuild for command-line builds)
- .NET Framework 4.7.2

## Getting the code

```bash
git clone https://github.com/msufiyanpk/metro-navigation-system.git
cd metro-navigation-system
```

## Opening in Visual Studio

Open [`src/MetroApp/Metro App.csproj`](../src/MetroApp/Metro%20App.csproj) directly — there is no solution file. Build and run with `F5`.

## Building from the command line

```bash
dotnet build "src/MetroApp/Metro App.csproj" -c Release
```

The compiled executable is written to `src/MetroApp/bin/Release/Metro Navigation System.exe`.

## Project layout

- `src/MetroApp/` — all application source (forms, business logic, embedded resources, and the `.csproj`)
- `src/MetroApp/lib/` — vendored reference assemblies used via `HintPath` (`System.Buffers`, `System.Memory`, etc.)
- `scripts/` — release packaging automation (see [deployment docs](deployment.md))

## Runtime data

At runtime, the app writes trip history to `Metro App Travel History/` next to the executable. This directory is created automatically and is not tracked in git.
