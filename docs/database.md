# Data Storage

The Metro Navigation System has no relational database, no ORM, and no server-side storage — it's a fully offline, single-user desktop app. All persisted state is flat text files written next to the executable by [`TripHistoryService`](../src/MetroApp/TripHistoryService.cs) (see [api.md](api.md) for its public interface).

## Storage location

```
<app directory>/Metro App Travel History/
├── TripNumber.txt       # single integer — the last used trip number
├── Travel History.txt   # append-only log of every trip ever taken
└── Receipt.txt          # overwritten with the most recent trip only
```

This folder is created automatically on the first completed trip and is not tracked in git (see [.gitignore](../.gitignore)).

## File formats

### `TripNumber.txt`

A single integer, incremented on every `SaveTrip` call:

```
7
```

### `Travel History.txt`

Append-only. Each trip adds one block in this format:

```
Trip 7:
Starting Station: Millennium Mall
Final Station: Drigh Road
Distance: 2 km
Time: 4:32 PM
Date: Friday, 3 July 2026

```

### `Receipt.txt`

Same block format as above, but always **overwritten** (not appended) with only the latest trip — this is what the Receipt screen reads via `TripHistoryService.ReadLatestReceipt()`.

## Why not a real database?

The app has exactly one "table" (trips) and one user (whoever is running the app on that machine), with no querying beyond "show me the last trip." A flat append-only log is simpler to reason about, ships with zero dependencies, and is human-readable if a user wants to open it directly. If the app ever needs querying, filtering, or multi-device sync, this is the layer that would be replaced with SQLite — see [architecture.md](architecture.md) for where it plugs into the rest of the app.
