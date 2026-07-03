# API Reference

This is a WinForms desktop application, not a web service — there is no HTTP/REST API. This document instead covers the internal public class surface that forms use to talk to the engine and helper services, so a contributor can extend the app without reading every form's code-behind.

## `Metro_App.Backend.MetroNetwork`

Static class holding the station graph and route calculation. See [architecture.md](architecture.md) for how the algorithm works internally.

```csharp
public static class MetroNetwork
{
    public static readonly string[] Stations; // 10 station names, in graph index order

    public static RouteResult FindShortestRoute(int startIndex, int endIndex);
}
```

- `Stations` — ordered list of station names; the index into this array is also the index into the internal adjacency matrix.
- `FindShortestRoute(startIndex, endIndex)` — runs Dijkstra's algorithm and returns a `RouteResult`, or `null` if no path exists. Throws `ArgumentOutOfRangeException` if either index is outside `0..Stations.Length - 1`.

### `Metro_App.Backend.RouteResult`

```csharp
public sealed class RouteResult
{
    public IReadOnlyList<string> Stations { get; }
    public int Distance { get; }
    public string DisplayPath { get; } // e.g. "Millennium Mall -> Drigh Road"
}
```

## `Metro_App.Backend.TripHistoryService`

Static class that persists trip receipts to a local text log under `Metro App Travel History/` next to the executable.

```csharp
public static class TripHistoryService
{
    public static string ReceiptFilePath { get; }

    public static string SaveTrip(string startStation, string endStation, int distance);
    public static string ReadLatestReceipt();
}
```

- `SaveTrip(...)` — appends a formatted trip entry to `Travel History.txt`, overwrites `Receipt.txt` with the same entry, increments the persisted trip counter, and returns the formatted trip text.
- `ReadLatestReceipt()` — returns the contents of the most recently written receipt, or an empty string if none exists yet.

See [database.md](database.md) for the on-disk file formats.

## `Metro_App.FormNavigator`

```csharp
public static class FormNavigator
{
    public static void ShowNext(Form currentForm, Form nextForm);
}
```

Shows `nextForm` and hides `currentForm`, keeping exactly one form active at a time. Used by every screen transition in the wizard.

## `Metro_App.SoundHelper`

```csharp
public static class SoundHelper
{
    public static void PlayTap();
}
```

Plays a short tap sound (`Console.Beep(1200, 35)`) on a background task for button-click feedback. Fails silently on systems without a sound device.

## `Metro_App.CustomMessageBox`

```csharp
public class CustomMessageBox : Form
{
    public static DialogResult Show(string text, string caption = "Information");
}
```

Drop-in replacement for `MessageBox.Show` styled to match the app's dark theme. Always shows a single OK button and returns `DialogResult.OK`.
