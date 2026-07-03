# Tests

There is currently no automated test suite for this project — it is validated manually by exercising the wizard flow (`Welcome` → `Choices` → `Metro Map` → `Stations` → `Shortest Path` → `Receipt`) after each change.

## Adding automated tests

The route-calculation logic in [`MetroNetwork.cs`](../src/MetroApp/MetroNetwork.cs) (Dijkstra's algorithm over a fixed adjacency matrix) and [`TripHistoryService.cs`](../src/MetroApp/TripHistoryService.cs) (file-based trip logging) are the most testable, UI-independent pieces. To add coverage:

1. Create a new class library project, e.g. `tests/MetroApp.Tests/MetroApp.Tests.csproj`, targeting the same `.NET Framework 4.7.2` (or a compatible test framework such as MSTest/NUnit/xUnit).
2. Reference `src/MetroApp/Metro App.csproj`.
3. Add tests for shortest-path results between known station pairs, and for `TripHistoryService` read/write round-trips using a temp directory.
4. Wire the test project into [`.github/workflows/ci.yml`](../.github/workflows/ci.yml) with a `dotnet test` (or `vstest.console`) step.

Manual testing of the WinForms UI itself (layout, navigation, receipt printing) will still be required, since form interaction isn't practically covered by unit tests in this codebase.
