# Changelog

All notable changes to this project will be documented in this file.

## [v1.1.5] - 2026-06-27 ("Teal")

### Added
- **Premium Custom Message Boxes**: Created `CustomMessageBox.cs` to show a beautiful, dark-themed, and modern looking modal dialog matching the app design system.
- **Teal Print Button**: Generated and integrated `btn_print.png` asset to match the visual design system.
- **Form Print Logic**: Clicking "Yes" on the Receipt screen displays the ticket details, hides "Yes" and "No" buttons and query labels, and reveals the "Print" button.
- **Custom Destination Buttons**: Replaced dropdown combo boxes on the Shortest Path screen with custom Sky Blue (`btn_first_destination.png`) and Amber (`btn_final_destination.png`) graphical buttons that trigger a custom dark context list, displaying chosen values on bold white labels over the map.
- **Map Pin Clicks**: Wired Click handlers for map pin radio buttons on the Stations page to pop up their names.

### Changed
- **Swapped Options Order**: Positioned "Metro Map" as the first choice and "Stations" as the second choice on the Choices menu.
- **Choices Layout Improvements**: Shifted option buttons left (X=120) and description labels left (X=340) to prevent text clipping. Styled labels with Hand cursors and wired them to navigate on click.
- **Equidistant Button Layouts**: Repositioned Yes/No buttons on the receipt screen to be mathematically equidistant from corners and each other.
- **Wizard Sequence**: Swapped navigation order to go `Choices` -> `Metro Map` -> `Stations` -> `Shortest Path` -> `Receipt`.
- **Role Title**: Renamed role title from "Lead Developer" to "Software Engineer" in all credits and layout panels.

### Removed
- **Stations Dropdown Menu**: Removed the dropdown selection combobox (`comboBox1`) and associated event handlers from the `Stations` page.

## [v1.1.0] - 2026-06-21 ("Crimson")

### Added
- **Shortest Path Calculation**: Leveraged Dijkstra's algorithm to compute the optimal path between metro stations.
- **Karachi Metro Visual Map**: Responsive map interface with active checkboxes/pins representing station selections.
- **Trip receipt & History Logging**: Auto-logging trip receipts (date, distance, route) in a local `Metro App Travel History/` directory.
- **Interactive Options Panel**: Selection controls for map viewing, shortest route, station search, and developer credits.
- **Tap Sound FX**: Play audio feedback tap sound upon buttons clicking.
- **App Icon**: Finalized application icon configuration.
- **MIT License**: The project is now properly licensed and attributed.
- **CI/CD**: GitHub Actions workflows validate the build on every push.
- **PowerShell packaging script**: Included script `package-release.ps1` to stage and zip release assemblies.

## [v1.0.5] - 2026-06-26 ("Neon")

### Added
- Flat, transparent **Exit Button** on the Welcome screen.
- **Dynamic Assembly Version Binding**: The Credits screen now reads version info directly from the assembly.
- **Smart User Redirection routing**: Passed `cameFromChoices` context flags to screen constructors to support conditional Back button routing (returning to Choices screen when opened directly, or returning to the previous wizard step when in the sequential loop).

### Changed
- **Synchronized Button Dimensions**: Re-aligned and resized all core navigation buttons (Back, Next, Exit, Find) to `120 x 40` (and `Yes`/`No` to `120 x 45` to match asset aspect ratios).
- **Equidistant Spacing**: Bottom navigation buttons now sit symmetrically at `X = 500` (Back) and `X = 640` (Next) with a clean `20` pixel gap.
- **DPI Layout Scaling Fix**: Moved programmatic control coordinates out of constructors and into designer configurations to allow correct WinForms AutoScale scaling on high-DPI displays.
- **Fixed Dialog Sizing**: Set `FormBorderStyle = FormBorderStyle.FixedDialog` and disabled the Maximize button on all forms to prevent stretching and misalignment on larger screens.
- **Corrected Stations Map Markers**: Rewrote the switch selection changed mappings in `Stations.cs` to highlight the exact physical station marker on the map.
- **High-Contrast Text**: Changed Choices description labels to white, bold Segoe UI text for high visibility against the dark background.
- **Wizard Endpoint**: Removed the Next button from the Receipt Generation screen and hid the Next button on the Credits screen, ending the wizard loop at Receipt Generation.
- **Credits Back Button Alignment**: Relocated the Credits screen Back button to the bottom-left `(60, 500)` to match other screens, routing it directly back to the main Options screen.

### Fixed
- **Button Transparency Artifacts**: Parented map controls (`button1`, `button2`, `buttonNext`, and all radio button markers) to their background `PictureBox` containers, resolving WinForms transparent border outlines.
- **Welcome Start Button Graphical Bug**: Cleared out duplicate/stretched background image configurations on the Start button (`pictureBox2`) to resolve clipping.
- **Radio Button Outline Box**: Formatted stations map highlights with transparent backgrounds to prevent square dark borders.
- **Button Text Overlap**: Removed textual property overrides on the "Show Stations on Map" button since text is pre-rendered in the graphical button asset.

---

## [v1.0.0] - 2026-06-21 ("Magenta") — Pre-release

### Added
- **Dijkstra Shortest Path Engine**: Initial graph/adjacency-matrix implementation.
- **Core Wizard Screens**: Welcome, Choices, Metro Map, Stations, Shortest Path, and Receipt Generation, with basic navigation.
- **Trip Receipt & History Logging**: First pass at local text-file trip logging.
- **Tap Sound FX**: Basic audio feedback on button clicks.
- **Initial App Icon**.

This was the first public preview build — unlicensed, unpolished, and without CI. See [docs/releases/v1.0.0.md](docs/releases/v1.0.0.md).
