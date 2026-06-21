# Metro Navigation System

A Windows desktop application for navigating the Karachi Metro network. Built with C# and Windows Forms (.NET Framework 4.7.2), it calculates the shortest route between any two stations using Dijkstra's algorithm and generates printable trip receipts.

## Features

- **Shortest Path Finder** — select any two stations and get the optimal route with total distance
- **Interactive Metro Map** — visual map of the Karachi Metro network
- **Trip Receipt Generation** — auto-generates and saves a receipt for every trip
- **Travel History** — persists all trips locally with date, time, and route details
- **Station Browser** — browse all stations on the network

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

## Branch Strategy

| Branch | Purpose |
|--------|---------|
| `main` | Complete, buildable codebase — integration target for all PRs |
| `backend` | Development branch for `Backend/` changes (graph, algorithms, services) |
| `frontend` | Development branch for UI changes (WinForms, Resources, form logic) |

> All branches carry the full codebase so the project always compiles. Feature work is done on `backend` or `frontend` and merged into `main` via pull request.

## Requirements

- Windows OS
- Visual Studio 2019 or later
- .NET Framework 4.7.2

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/msufiyanpk/metro-navigation-system.git
   ```
2. Open `Metro App.csproj` in Visual Studio
3. Build and run (`F5`)

The application saves travel history to:
```
<app directory>/Metro App Travel History/
```

## How It Works

The metro network is represented as a weighted adjacency matrix. When the user selects a start and end station, `MetroNetwork.FindShortestRoute()` runs Dijkstra's algorithm to find the path with the minimum total distance. The result is displayed with the full station sequence and distance in km, and `TripHistoryService` saves the trip to disk and writes a receipt file.

## CI / CD

GitHub Actions workflows validate the build on every push to `main`, `backend`, and `frontend`:

- **Backend Validation** — restores and builds the project via MSBuild
- **Frontend Validation** — builds the WinForms application via MSBuild

Both workflows run on `windows-latest`.

## License

This project is licensed under the [MIT License](LICENSE).
