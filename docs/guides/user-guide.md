# User Guide

The app walks you through a fixed wizard sequence:

`Welcome` → `Choices` → `Metro Map` → `Stations` → `Shortest Path` → `Receipt`

## Welcome

The landing screen. Click **Start** to begin, or **Exit** to close the app.

## Choices

The main options menu. From here you can jump directly to any screen:

- **Metro Map** — view the full network map.
- **Stations** — browse all stations.
- **Shortest Route** — find the shortest path between two stations.
- **Developer Credits** — view project and developer information.

Option descriptions are clickable and navigate directly to the corresponding screen.

## Metro Map

Displays the full Karachi Metro network map.

## Stations

Browse all 10 stations. Toggle **Show Stations on Map** to display or hide station pin markers over the map image. Clicking a station pin pops up a dialog with that station's full name.

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

## Shortest Path

Pick a **Start Station** and an **End Station** using the destination select buttons (each opens a dropdown list of stations). Click **Find** to compute the shortest route with Dijkstra's algorithm — see [architecture overview](../architecture/overview.md) for how this works internally. The result highlights the route on the map and shows the total distance.

## Receipt

After finding a route, choose whether to generate a printable trip receipt:

- **Yes** — displays the ticket details (start, end, distance, timestamp) and reveals a **Print** button. The trip is also appended to the local travel history log.
- **No** — returns to the Options screen without generating a receipt.
