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

### [v1.0.0] - 2026-06-21 ("Initial")
The initial release featuring the Dijkstra path calculation backend, interactive metro map viewing, travel history logging, dropdown station browsers, and trip receipt printing.

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
├── Backend/
│   ├── MetroNetwork.cs         # Station graph + Dijkstra shortest path algorithm
│   └── TripHistoryService.cs   # Trip persistence and receipt generation
├── Frontend/
│   └── FormNavigator.cs        # WinForms navigation helper
├── Resources/
│   ├── background.png          # UI background images
│   ├── metro map.jpg           # Metro network map
│   └── *.jpg / *.png          # Station and UI assets
├── Welcome.cs                  # Landing screen
├── Choices.cs                  # Main menu
├── Stations.cs                 # Station browser
├── Map.cs                      # Metro map viewer
├── Shortest Path.cs            # Route finder UI
├── ReceiptGeneration.cs        # Trip receipt screen
├── Program.cs                  # Application entry point
└── Metro App.csproj            # Project file
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

This project is licensed under the [MIT License](LICENSE) © 2026 Mohammad Sufiyan Aasim.
