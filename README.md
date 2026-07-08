<div align="center">

<img src="src/MetroApp/Resources/metro_app_icon.png" alt="Metro Navigation System Logo" width="110" />

# Metro Navigation System

**A Windows desktop route planner for the Karachi Metro network**

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=flat&logo=dotnet&logoColor=white)](docs/Development.md)
[![Version](https://img.shields.io/badge/version-1.1.5%20Teal-0d9488?style=flat)](docs/releases/v1.1.5.md)
[![License: MIT](https://img.shields.io/badge/License-MIT-22c55e?style=flat)](LICENSE)
[![Platform](https://img.shields.io/badge/platform-Windows-64748b?style=flat)]()
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-0ea5e9?style=flat)](CONTRIBUTING.md)

Calculates the shortest route between any two stations with Dijkstra's algorithm, highlights it interactively on the map, and prints a trip receipt — all offline, no installer, no accounts.

[**Download .exe**](docs/releases/v1.1.5.md) · [**Changelog**](CHANGELOG.md) · [**Roadmap**](ROADMAP.md) · [**Report a Bug**](.github/ISSUE_TEMPLATE/bug_report.md)

</div>

---

## ✨ Features

### 🧭 Shortest Path Finder
- Dijkstra's algorithm over a 10-station weighted graph
- Custom Sky Blue / Amber destination-select buttons with dropdown station pickers
- Highlights the computed route and total distance directly on the map

### 🗺️ Interactive Metro Map
- Full visual map of the Karachi Metro network
- Clickable station pins that pop up the station's full name

### 🧾 Trip Receipts
- Dedicated printable receipt flow with a custom Print button
- Auto-saves every trip (start, end, distance, timestamp) to a local history log

### 🚉 Station Browser
- Browse all 10 stations with a toggleable "Show Stations on Map" overlay

### 🎨 Custom UI
- Dark-themed `CustomMessageBox` replacing standard Windows dialogs
- Equidistant, DPI-aware layouts across every screen

---

## 🏗️ Architecture

```
┌──────────────────────────────────────────────────────────┐
│                      WinForms UI                          │
│   Welcome → Choices → Map → Stations → ShortestPath →      │
│                        Receipt                             │
└───────┬───────────────┬──────────────┬─────────────────────┘
        │               │              │
        ▼               ▼              ▼
 FormNavigator     SoundHelper    MetroNetwork
 (screen swap)    (tap feedback)  (Dijkstra engine)
                                        │
                                        ▼
                                TripHistoryService
                                (local text-file log)
```

Full breakdown in [docs/Architecture.md](docs/Architecture.md).

---

## 🛠️ Technology Stack

### NuGet packages

| Package | Purpose |
|---------|---------|
| [System.Resources.Extensions](https://www.nuget.org/packages/System.Resources.Extensions) | Non-string embedded resource (de)serialization |

### Vendored reference assemblies (`src/MetroApp/lib/`)

| Assembly | Purpose |
|----------|---------|
| System.Buffers, System.Memory, System.Numerics.Vectors, System.Runtime.CompilerServices.Unsafe | Compatibility shims required by `System.Resources.Extensions` on .NET Framework 4.7.2 |

### .NET Framework (no install needed)

| Namespace | Purpose |
|-----------|---------|
| `System.Windows.Forms` | GUI framework — forms, controls, dialogs |
| `System.Drawing` | Graphics, icons, and image rendering |
| `System.IO` | Trip history file persistence |
| `System.Reflection` | Dynamic assembly-version binding on the Credits screen |
| `System` (`Console.Beep`) | Tap sound feedback |

---

## 🚀 Getting Started

### Requirements
- Windows OS
- Visual Studio 2019 or later (or the .NET Framework 4.7.2 targeting pack for CLI builds)

### Clone and run

```bash
git clone https://github.com/SufiyanAasim/metro-navigation-system.git
cd metro-navigation-system
```

Open `src/MetroApp/Metro App.csproj` in Visual Studio and build/run (`F5`), or build from the command line:

```bash
dotnet build "src/MetroApp/Metro App.csproj" -c Release
```

Or download a packaged build from [docs/releases/v1.1.5.md](docs/releases/v1.1.5.md).

The app saves travel history to `<app directory>/Metro App Travel History/`. Full setup details in [docs/Development.md](docs/Development.md).

---

## 🗂️ Project Structure

```
metro-navigation-system/
├── .github/                # CI/CD workflows, issue/PR templates, CODEOWNERS
├── docs/
│   ├── Architecture.md
│   ├── Database.md
│   ├── Development.md
│   ├── Troubleshooting.md
│   └── releases/            # Per-version release notes
├── scripts/
│   └── package-release.ps1
├── src/
│   └── MetroApp/
│       ├── Metro App.csproj
│       ├── Properties/      # Assembly and settings configuration
│       ├── Resources/       # UI backgrounds, icons, and button assets
│       ├── lib/              # Vendored reference assemblies
│       ├── Choices.cs
│       ├── Credits.cs
│       ├── FormNavigator.cs
│       ├── Map.cs
│       ├── MetroNetwork.cs
│       ├── Program.cs
│       ├── ReceiptGeneration.cs
│       ├── Shortest Path.cs
│       ├── SoundHelper.cs
│       ├── Stations.cs
│       └── TripHistoryService.cs
├── tests/                    # Test placeholder and guidance
├── CHANGELOG.md
├── CODE_OF_CONDUCT.md
├── CONTRIBUTING.md
├── LICENSE
├── README.md
├── RELEASE.md
├── ROADMAP.md
├── SECURITY.md
└── SUPPORT.md
```

---

## 🚉 Metro Network

The app models 10 stations on the Karachi Metro:

| # | Station |
|---|---------|
| 0 | Millennium Mall |
| 1 | Numaish |
| 2 | FTC |
| 3 | Frere Hall |
| 4 | KPT Interchange |
| 5 | Defence Morr |
| 6 | Indus Hospital |
| 7 | Shaan Chowrangi |
| 8 | Singer Chowrangi |
| 9 | Drigh Road |

---

## 🧪 Testing

There is no automated test suite yet — the wizard flow is validated manually after each change. See [tests/README.md](tests/README.md) for what's testable and how to add coverage.

---

## 📦 Building the Windows Executable

```powershell
./scripts/package-release.ps1 -Version "1.1.5"
```

Builds in Release mode and stages `Metro Navigation System.exe` plus its config, runtime DLLs, and docs into `MetroNavigationSystem-v1.1.5.zip`. See [docs/Development.md](docs/Development.md).

---

## 🛡️ Security

This is a fully offline, single-user desktop app — no network calls, no accounts, no database (see [docs/Architecture.md](docs/Architecture.md) and [docs/Database.md](docs/Database.md)). The only persisted state is a local trip-history text log. See [SECURITY.md](SECURITY.md) to report a vulnerability.

---

## 🤝 Contributors

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/SufiyanAasim">
        <img src="https://github.com/SufiyanAasim.png" width="72" alt="SufiyanAasim"/><br/>
        <sub><b>Mohammad Sufiyan Aasim</b></sub>
      </a><br/>
      <sub>System Architect · AI/MLOps · Docs</sub>
    </td>
    <td align="center">
      <a href="https://github.com/FahadBinNasir">
        <img src="https://github.com/FahadBinNasir.png" width="72" alt="FahadBinNasir"/><br/>
        <sub><b>Fahad Bin Nasir</b></sub>
      </a><br/>
      <sub>Front-end Development</sub>
    </td>
  </tr>
</table>

See [CONTRIBUTING.md](CONTRIBUTING.md) to get involved.

---

## 📄 License

[MIT License](LICENSE) © 2026 Metro Navigation System Contributors.

---

<div align="center">

⭐ **Star this repo if it helped you plan a route.**

[Report Bug](.github/ISSUE_TEMPLATE/bug_report.md) · [Request Feature](.github/ISSUE_TEMPLATE/feature_request.md)

</div>
