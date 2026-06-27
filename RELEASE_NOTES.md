# Release Notes: Metro Navigation System v2.0.0 ("Teal")

Welcome to the **v2.0.0 ("Teal")** release of the **Metro Navigation System**! This release brings a major version upgrade featuring a dedicated printable receipt flow, premium custom dark message boxes, options menu restructuring, simplified station maps, wizard flow adjustments, and developer title renaming.

## Release Metadata
- **Version**: `v2.0.0` (Codename: **Teal**)
- **Release Date**: 2026-06-27
- **Platform**: Windows (x86/x64)
- **Target Framework**: .NET Framework 4.7.2

## What's New in this Release

### 1. Premium Custom Message Boxes
- Replaced standard gray Windows OS message boxes with a custom styled dialog (`CustomMessageBox.cs`).
- Renders a modern deep dark blue background (`#0F192D`), crisp Segoe UI typography, and a custom flat Teal OK button (`#0D9488`).

### 2. Interactive & Clipless Options Screen
- **Shifted Option Layout**: Moved option buttons left (X=120) and description labels left (X=340) to completely prevent description text overflow or clipping on standard screens.
- **Clickable Descriptions**: Description text labels are now fully interactive, transforming the cursor to a Hand on hover and navigating the user directly to the respective page when clicked.

### 3. Equidistant Control Layouts
- Repositioned the **Yes** and **No** buttons on the Receipt screen to be perfectly equidistant from each other and the left/right screen borders (Yes at X=180, No at X=478).

### 4. Custom Destination Select Buttons
- Replaced standard dropdown combo boxes on the Shortest Path screen with custom Sky Blue and Amber destination buttons:
  - **Start Station** (`btn_first_destination.png`)
  - **End Station** (`btn_final_destination.png`)
- Clicking either button spawns a custom dark dropdown menu list of stations. Selected choices display in bold white text overlays directly on the map.

### 5. Dedicated Printable Receipt Screen Flow
- **Teal Print Button**: Created and integrated a clean, custom `btn_print.png` matching the visual style of other navigation buttons.
- **Dynamic Controls Hiding**: Clicking **Yes** to generate a receipt now hides the Yes/No buttons and the query label, showing the printed text details on a clean ticket with only the custom Print button visible.
- **Redirects**: Clicking **No** immediately routes the user back to the main options screen.

### 6. Restructured Menu Layout & Wizard Loop
- **Swapped Screen Layout**: Re-positioned the options so "Metro Map" appears first (top) and "Stations" second (middle).
- **Corrected Wizard Flow**: Re-aligned the step-by-step sequential navigation flow to:
  `Welcome` -> `Choices` -> `Metro Map` -> `Stations` -> `Shortest Route` -> `Receipt`.
- **Dynamic Redirection Contexts**: Handled the backtracking and forward transitions to ensure users can access screens directly or through the loop without dead ends.

### 7. Stations Page Map Pin Clicks & Dropdown Cleanup
- **Removed Dropdown Menu**: Deleted the old station dropdown combobox (`comboBox1`) and its keyboard event handlers. The Stations page now relies cleanly and solely on the **Show Stations on Map** toggle button to display/hide all network pins.
- **Station Info Popups**: Clicking any radio button marker pin on the map now displays a custom dialog box presenting the station's full name.

### 8. Software Engineer Title Renaming
- Changed the developer credits role title from "Lead Developer" to "Software Engineer" on both the Credits form and in the repository documentation (`README.md`).

---

## Developer Credits
Developed by **M Sufiyan Aasim**.
- **Email**: [sufiyanaasim@outlook.com](mailto:sufiyanaasim@outlook.com)
- **GitHub**: [msufiyanpk](https://github.com/msufiyanpk)
