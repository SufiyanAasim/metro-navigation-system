# Metro Navigation System

A Windows desktop application for navigating the Karachi Metro network. Built with C# and Windows Forms (.NET Framework 4.7.2), it calculates the shortest route between any two stations using Dijkstra's algorithm, highlights routes interactively, and generates printable trip receipts.

---

## Releases

### [v2.0.0] - 2026-06-27 ("Teal")
The latest release of the application featuring:
- **Premium Custom Message Boxes**: Replaced the standard gray OS dialog popups with a beautiful, dark-themed `CustomMessageBox` that matches the dark aesthetics of the application.
- **Interactive & Polished Options Screen**: Shifted option buttons and description texts slightly to the left to completely prevent text clipping on standard resolutions. Description labels are now interactive with a Hand cursor and can be clicked directly to open the respective screens.
- **Equidistant Control Layouts**: Repositioned Yes/No buttons on the receipt screen to be perfectly equidistant from each other and both left and right screen borders.
- **Custom Destination Select Buttons**: Replaced standard dropdown combo boxes on the Shortest Path screen with flat styled Sky Blue and Amber selection buttons that spawn custom dark-themed dropdown menus, displaying choices on bold white map overlays.
- **Printable Receipt Screen Updates**: Integrated a flat vector-style Print button that appears when "Yes" is clicked. The Yes/No buttons and query text hide automatically to present the clean ticket. Clicking "No" returns the user to the Options screen.
- **Swapped Screen Layout & Wizard Flow**: Re-ordered choices so "Metro Map" appears first (top) and "Stations" appears second. Updated Back/Next transitions to match this flow sequentially.
- **Stations Page Cleanup**: Removed the redundant stations dropdown selection menu, keeping only the "Show Stations on Map" toggle button. Clicking a station pin on the map shows a message box displaying the station name.
- **Software Engineer Title**: Updated the developer role designation in credits from "Lead Developer" to "Software Engineer".

### [v1.1.5] - 2026-06-26 ("Neon")
The latest release of the application featuring:
- **Visual & Transparency Fixes**: Parented controls dynamically on maps to fix rounded transparent border outlines.
- **Redesigned Welcome & Developer Screens**: Cleaned up the landing screen with visual alignment and a new Exit button; removed/hid redundant wizard navigation paths on Credits.
- **Equidistant Button Layout**: Synchronized all general buttons to `120 x 40` dimensions with a clean `20` pixel margin.
- **Corrected Map Coordinates**: Fixed map markers coordinates mapping switches in Stations selection changed logic.
- **Changelog & Technical Specs**: Added in-depth [Changelog](CHANGELOG.md) and technical [architecture documentation](docs/architecture/overview.md).

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

*   [docs/architecture/overview.md](docs/architecture/overview.md) — Technical details of Dijkstra's algorithm, graph representation (adjacency matrix), and the form-navigation framework.
*   [docs/guides/user-guide.md](docs/guides/user-guide.md) — Walkthrough of the app's wizard flow and screens.
*   [docs/development/setup.md](docs/development/setup.md) — Environment setup and build instructions.
*   [docs/deployment/building-and-releasing.md](docs/deployment/building-and-releasing.md) — Packaging and release automation.
*   [docs/troubleshooting/common-issues.md](docs/troubleshooting/common-issues.md) — Known issues and fixes.
*   [CHANGELOG.md](CHANGELOG.md) — Chronological history of all features, enhancements, and fixes added to the project.
*   [docs/releases/](docs/releases/) — Detailed per-version release notes.

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
metro-navigation-system/
├── .github/                     # CI/CD workflows, issue/PR templates, CODEOWNERS
├── docs/                        # Architecture, guides, deployment, and troubleshooting docs
│   ├── architecture/            # System design and algorithm details
│   ├── deployment/              # Build and release process
│   ├── development/             # Environment setup
│   ├── guides/                  # End-user walkthrough
│   ├── releases/                 # Per-version release notes
│   └── troubleshooting/         # Known issues and fixes
├── scripts/                     # Release packaging automation
│   └── package-release.ps1
├── src/
│   └── MetroApp/                 # All application source
│       ├── Metro App.csproj     # C# MSBuild project file
│       ├── Properties/          # Assembly and settings configuration
│       ├── Resources/           # UI backgrounds, icons, and button assets
│       ├── lib/                  # Vendored reference assemblies
│       ├── Choices.cs           # Main menu/options selection screen
│       ├── Credits.cs           # Developer credits & project roles screen
│       ├── FormNavigator.cs     # WinForms navigation helper utility
│       ├── Map.cs               # Metro map and station marker visualizer
│       ├── MetroNetwork.cs      # Graph representation & Dijkstra pathfinding
│       ├── Program.cs           # WinForms application entry point
│       ├── ReceiptGeneration.cs # Trip receipt generator and screen
│       ├── Shortest Path.cs     # Route calculator and path finder UI
│       ├── SoundHelper.cs       # Sound effect and click audio helper
│       ├── Stations.cs          # Interactive station browser
│       └── TripHistoryService.cs # Trip logger and receipts builder
├── tests/                        # Test placeholder and guidance (see tests/README.md)
├── CHANGELOG.md                 # Detailed version changelog
├── CONTRIBUTING.md              # Contribution guidelines
├── LICENSE                      # MIT license terms
├── README.md                    # Getting started and project overview
├── RELEASE.md                   # Release process
├── SECURITY.md                  # Security policy
├── SUPPORT.md                   # Support channels
└── CODE_OF_CONDUCT.md           # Community guidelines
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
2. Open `src/MetroApp/Metro App.csproj` in Visual Studio.
3. Build and run (`F5`).

Or build from the command line:
```bash
dotnet build "src/MetroApp/Metro App.csproj" -c Release
```

The application saves travel history to:
```
<app directory>/Metro App Travel History/
```

See [docs/development/setup.md](docs/development/setup.md) for full setup details.

---

## CI / CD

- [`.github/workflows/ci.yml`](.github/workflows/ci.yml) — restores and builds the WinForms project via MSBuild on every push and pull request to `main`.
- [`.github/workflows/release.yml`](.github/workflows/release.yml) — on a pushed `v*` tag, builds, packages, and publishes a GitHub Release. See [RELEASE.md](RELEASE.md).

---

## Developer Credits

Developed by **Mohammad Sufiyan Aasim** (Software Engineer, UI Designer & System Architect).
- **Email**: [sufiyanaasim@outlook.com](mailto:sufiyanaasim@outlook.com)
- **GitHub**: [msufiyanpk](https://github.com/msufiyanpk)

---

## License

This project is licensed under the [MIT License](LICENSE) © 2026 M Sufiyan Aasim ([@msufiyanpk](https://github.com/msufiyanpk)).
