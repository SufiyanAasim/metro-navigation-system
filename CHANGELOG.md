# Changelog

All notable changes to Metro Navigation System are documented here.

The format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/). This project uses [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

---

## [1.1.5] — "Teal" — 2026-06-27

### Added
- **Premium Custom Message Boxes.** Created `CustomMessageBox.cs` to show a dark-themed, modern modal dialog matching the app's design system.
- **Teal Print Button.** Generated and integrated `btn_print.png` to match the visual design system.
- **Form Print Logic.** Clicking "Yes" on the Receipt screen displays the ticket details, hides the Yes/No buttons and query label, and reveals the Print button.
- **Custom Destination Buttons.** Replaced dropdown combo boxes on the Shortest Path screen with custom Sky Blue (`btn_first_destination.png`) and Amber (`btn_final_destination.png`) graphical buttons that trigger a custom dark context list, displaying chosen values on bold white labels over the map.
- **Map Pin Clicks.** Wired click handlers for map pin radio buttons on the Stations page to pop up their names.

### Changed
- **Swapped options order.** "Metro Map" is now the first choice and "Stations" the second on the Choices menu.
- **Choices layout improvements.** Shifted option buttons left (X=120) and description labels left (X=340) to prevent text clipping. Labels now show a Hand cursor and navigate on click.
- **Equidistant button layouts.** Repositioned Yes/No buttons on the Receipt screen to be mathematically equidistant from corners and each other.
- **Wizard sequence.** Swapped navigation order to `Choices` → `Metro Map` → `Stations` → `Shortest Path` → `Receipt`.
- **Role title.** Renamed the developer role title from "Lead Developer" to "Software Engineer" in all credits and layout panels.

### Removed
- **Stations dropdown menu.** Removed the dropdown selection combobox (`comboBox1`) and its associated event handlers from the Stations page.

---

## [1.1.0] — "Crimson" — 2026-06-21

### Added
- **Shortest path calculation.** Dijkstra's algorithm computes the optimal path between any two metro stations.
- **Karachi Metro visual map.** Responsive map interface with active checkboxes/pins representing station selections.
- **Trip receipt & history logging.** Auto-logs trip receipts (date, distance, route) to a local `Metro App Travel History/` directory.
- **Interactive options panel.** Selection controls for map viewing, shortest route, station search, and developer credits.
- **Tap sound FX.** Audio feedback on button clicks.
- **App icon.** Finalized application icon configuration.
- **MIT License.** The project is now properly licensed and attributed.
- **CI/CD.** GitHub Actions workflows validate the build on every push.
- **PowerShell packaging script.** `package-release.ps1` stages and zips release assemblies.

### Changed
- Rewrote `README.md` with full setup, feature, and licensing information.

---

## [1.0.5] — "Neon" — 2026-06-26

### Added
- Flat, transparent **Exit Button** on the Welcome screen.
- **Dynamic assembly version binding.** The Credits screen now reads its version directly from the assembly.
- **Smart user redirection routing.** `cameFromChoices` context flags support conditional Back-button routing — back to Choices when opened directly, or back to the previous wizard step when navigating the sequential loop.

### Changed
- **Synchronized button dimensions.** Re-aligned and resized all core navigation buttons (Back, Next, Exit, Find) to `120 x 40` (Yes/No to `120 x 45` to match asset aspect ratios).
- **Equidistant spacing.** Bottom navigation buttons now sit symmetrically at `X = 500` (Back) and `X = 640` (Next) with a clean `20` pixel gap.
- **DPI layout scaling fix.** Moved programmatic control coordinates out of constructors and into designer configuration to allow correct WinForms `AutoScale` behavior on high-DPI displays.
- **Fixed dialog sizing.** Set `FormBorderStyle = FormBorderStyle.FixedDialog` and disabled the Maximize button on all forms.
- **Corrected Stations map markers.** Rewrote the switch/selection-changed mappings in `Stations.cs` to highlight the exact physical station marker on the map.
- **High-contrast text.** Choices description labels changed to white, bold Segoe UI text.
- **Wizard endpoint.** Removed the Next button from the Receipt Generation screen and hid it on the Credits screen, ending the wizard loop at Receipt Generation.
- **Credits Back button alignment.** Relocated to the bottom-left `(60, 500)` to match other screens.

### Fixed
- **Button transparency artifacts.** Parented map controls to their background `PictureBox` containers, resolving transparent border outlines.
- **Welcome Start button graphical bug.** Cleared duplicate/stretched background image configuration on the Start button.
- **Radio button outline box.** Formatted station map highlights with transparent backgrounds to prevent square dark borders.
- **Button text overlap.** Removed textual property overrides on the "Show Stations on Map" button since text is pre-rendered in the graphical asset.

---

## [1.0.0] — "Magenta" — 2026-06-21

> Pre-release. Internal development milestone — not publicly distributed.

### Added
- Initial project scaffold: `Program.cs` entry point, `Dijkstra.cs` route engine, and the six wizard-screen forms.
- **Dijkstra shortest path engine.** Initial graph/adjacency-matrix implementation.
- **Core wizard screens.** Welcome, Choices, Metro Map, Stations, Shortest Path, and Receipt Generation, with basic navigation.
- **Trip receipt & history logging.** First pass at local text-file trip logging.
- **Tap sound FX.** Basic audio feedback on button clicks.
- Initial app icon.

---

[1.1.5]: docs/releases/v1.1.5.md
[1.1.0]: docs/releases/v1.1.0.md
[1.0.5]: docs/releases/v1.0.5.md
[1.0.0]: docs/releases/v1.0.0.md
