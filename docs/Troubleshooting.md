# Troubleshooting

## Build fails with "assembly not found"

**Error:** `MSB3644` or similar for `System.Buffers` / `System.Memory` / `System.Resources.Extensions`.

These are vendored reference assemblies checked into `src/MetroApp/lib/` and wired up via `HintPath` in the `.csproj`. Confirm the DLLs are present there, and that you're building the current project file:
```bash
dotnet build "src/MetroApp/Metro App.csproj" -c Release
```

---

## `dotnet build` can't restore `System.Resources.Extensions`

This is a NuGet `PackageReference`. Ensure you have network access on first restore, or that the package is already in your local cache (`~/.nuget/packages`).

---

## Travel history file locked or app appears to hang on exit

Earlier versions of `TripHistoryService` could leave a file handle open on `Metro App Travel History/Travel History.txt`, causing a brief freeze when writing a new entry. This was fixed by ensuring file streams are properly disposed after each write. If you see this on a modified build, check that any custom changes to `TripHistoryService.cs` wrap file I/O in a `using` block.

---

## UI controls show a dark square/rectangle border artifact

WinForms controls placed directly on a form with a background image can render an opaque border instead of a transparent one. Parent the control (buttons, radio button markers) to the same `PictureBox` that holds the background image, rather than to the form itself.

---

## Layout looks stretched or misaligned on high-DPI displays

Set control positions and sizes in the designer (`.Designer.cs`) rather than programmatically in the form constructor, and let WinForms' `AutoScale` handle DPI scaling. Confirm `FormBorderStyle` is `FixedDialog` with the Maximize button disabled, to prevent resizing a fixed-layout screen.

---

## Credits screen shows the wrong version number

The version label is bound at runtime to the assembly version (`Properties/AssemblyInfo.cs`), not hardcoded. If it looks stale, rebuild after confirming `AssemblyVersion`/`AssemblyFileVersion` were bumped for the release.
