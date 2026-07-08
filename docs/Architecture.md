# Metro Navigation System Architecture

## System Design

The application employs a **layered desktop architecture** with distinct separation between presentation, route-calculation, and persistence tiers. Every screen in the wizard flow draws from the same shared engine and history log — there is a single source of truth for both.

## Component Breakdown

**Entry & Navigation Layer:**
The system launches through `Program.cs`, which starts the `Welcome` form. From there, `FormNavigator.ShowNext(currentForm, nextForm)` moves the user through the wizard — showing the next screen and hiding the current one so only one form is ever active at a time.

**Route Engine:**
`MetroNetwork.cs` houses the static `MetroNetwork` class and the `RouteResult` record, holding the 10-station adjacency matrix and running Dijkstra's algorithm to compute the shortest path and total distance between any two stations.

**Trip Persistence:**
`TripHistoryService.cs` manages all local file I/O — writing each computed trip to `Metro App Travel History/Travel History.txt`, maintaining a running trip counter, and exposing the latest receipt back to the Receipt Generation screen.

**Supporting Modules:**
- `SoundHelper.cs` — tap-sound audio feedback on button clicks
- `CustomMessageBox.cs` — themed replacement for standard Windows dialogs
- `Properties/AssemblyInfo.cs` — assembly metadata and the version read by the Credits screen

## Trust Model

The application has no authentication and no network layer by design — it is a fully offline, single-user desktop tool. There are no accounts to compromise and no credentials to store; the operating system's own file permissions are the only access boundary around the local trip-history log. See [SECURITY.md](../SECURITY.md) for the full policy.

## Persistence Model

Trip history is stored as flat text files rather than a database. See [Database.md](Database.md) for the exact file formats and why a relational database wasn't warranted for a single-user, single-record-type use case.
