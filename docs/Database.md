# Database

Metro Navigation System uses no relational database. All persisted state lives in flat text files under `<app directory>/Metro App Travel History/`, managed entirely by [`TripHistoryService.cs`](../src/MetroApp/TripHistoryService.cs).

---

## Files

### `TripNumber.txt`

| Field | Format | Description |
|-------|--------|-------------|
| trip number | Integer | The last used trip number; incremented on every `SaveTrip` call |

### `Travel History.txt`

Append-only. Each trip adds one block in this format:

| Field | Format | Description |
|-------|--------|-------------|
| `Trip {n}` | Integer | Sequential trip number |
| `Starting Station` | Text | Station name from `MetroNetwork.Stations` |
| `Final Station` | Text | Station name from `MetroNetwork.Stations` |
| `Distance` | Integer + "km" | Total route distance from `RouteResult.Distance` |
| `Time` | `h:mm tt` | Local time of the trip |
| `Date` | `dddd, d MMMM yyyy` | Local date of the trip |

### `Receipt.txt`

Same block format as `Travel History.txt`, but always **overwritten** (not appended) with only the latest trip — this is what the Receipt screen reads via `TripHistoryService.ReadLatestReceipt()`.

---

## Security

- Trip data is plain text with no personal identifiers beyond station names and timestamps.
- No credentials, accounts, or secrets are ever written to disk — see [SECURITY.md](../SECURITY.md).
- Access is constrained only by the operating system's own file permissions on `Metro App Travel History/`.

---

## Backup

There is no separate backup mechanism. `Receipt.txt` acts as a single-record snapshot of the most recent trip, while `Travel History.txt` retains the full append-only log — between the two, no trip data is ever silently discarded on write.
