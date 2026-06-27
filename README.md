# Metro Navigation System

A Windows desktop application for navigating the Karachi Metro network. Built with C# and Windows Forms (.NET Framework 4.7.2), it calculates the shortest route between any two stations using Dijkstra's algorithm, highlights routes interactively, and generates printable trip receipts.

---

## Releases

### [v1.1.5] - 2026-06-26 ("Neon")
The latest release of the application featuring:
- **Visual & Transparency Fixes**: Parented controls dynamically on maps to fix rounded transparent border outlines.
- **Redesigned Welcome & Developer Screens**: Cleaned up the landing screen with visual alignment and a new Exit button; removed/hid redundant wizard navigation paths on Credits.
- **Equidistant Button Layout**: Synchronized all general buttons to `120 x 40` dimensions with a clean `20` pixel margin.
- **Corrected Map Coordinates**: Fixed map markers coordinates mapping switches in Stations selection changed logic.
- **Changelog & Technical Specs**: Added in-depth [Changelog](CHANGELOG.md) and technical [About documentation](ABOUT.md).

### [v1.0.0] - 2026-06-21 ("Crimson")
The Crimson release featuring the Dijkstra path calculation backend, interactive metro map viewing, travel history logging, dropdown station browsers, and trip receipt printing.

---

## Features

- **Shortest Path Finder** — select any two stations and get the optimal route with total distance.
- **Interactive Metro Map** — visual map of the Karachi Metro network.
- **Trip Receipt Generation** — auto-generates and saves a receipt for every trip, with options to return to the main menu.
- **Travel History** — persists all trips locally with date, time, and route details.
- **Station Browser** — browse all stations on the network, with an interactive dropdown selection that highlights and checks station markers directly on the map.

---

## Documentation

For in-depth explanations of the system architecture and historical log files, please refer to:
*   [ABOUT.md](ABOUT.md) — Technical details of Dijkstra's algorithm, graph representation (adjacency matrix), and frontend form-navigation framework.
*   [CHANGELOG.md](CHANGELOG.md) — Chronological history of all features, enhancements, and fixes added to the project.
*   [RELEASE_NOTES.md](RELEASE_NOTES.md) — Version release metadata, runtime configurations, and download staging files.

---

## Metro Network

The app covers 10 stations on the Karachi Metro:

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

## Project Structure

```
Metro Navigation System/
├── .github/                    # CI/CD GitHub Actions workflows
├── Properties/                 # Assembly and settings configuration
│   └── AssemblyInfo.cs         # Metadata and version numbers
├── Resources/                  # UI design and background assets
│   ├── metro map.jpg           # Interactive metro map image
│   └── *.png / *.jpg           # Form backgrounds and styled buttons
├── ABOUT.md                    # In-depth architectural & technical specs
├── CHANGELOG.md                # Detailed version changelog
├── Choices.cs                  # Main menu/options selection screen
├── Credits.cs                  # Developer credits & project roles screen
├── FormNavigator.cs            # WinForms navigation helper utility
├── LICENSE                     # MIT license terms
├── Map.cs                      # Metro map and station marker visualizer
├── Metro App.csproj            # C# MSBuild project file
├── MetroNetwork.cs             # Graph representation & Dijkstra pathfinding
├── Program.cs                  # WinForms application entry point
├── README.md                   # Getting started and project overview
├── RELEASE_NOTES.md            # Release details & runtime configuration
├── ReceiptGeneration.cs        # Trip receipt generator and screen
├── Shortest Path.cs            # Route calculator and path finder UI
├── SoundHelper.cs              # Sound effect and click audio helper
├── Stations.cs                 # Interactive station browser
├── TripHistoryService.cs       # Trip logger and receipts builder
└── package-release.ps1         # PowerShell script to package zip releases
```

---

## Requirements

- Windows OS
- Visual Studio 2019 or later
- .NET Framework 4.7.2

---

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/msufiyanpk/metro-navigation-system.git
   ```
2. Open `Metro App.csproj` in Visual Studio.
3. Build and run (`F5`).

The application saves travel history to:
```
<app directory>/Metro App Travel History/
```

---

## CI / CD

GitHub Actions workflows validate the build on every push:

- **Build Validation** — restores and builds the WinForms project via MSBuild.

Both workflows run on `windows-latest`.

---

## Developer Credits

Developed by **Mohammad Sufiyan Aasim** (Lead Developer, UI Designer & System Architect).
- **Email**: [sufiyanaasim@outlook.com](mailto:sufiyanaasim@outlook.com)
- **GitHub**: [msufiyanpk](https://github.com/msufiyanpk)

---

## License

This project is licensed under the [MIT License](LICENSE) © 2026 M Sufiyan Aasim ([@msufiyanpk](https://github.com/msufiyanpk)).
