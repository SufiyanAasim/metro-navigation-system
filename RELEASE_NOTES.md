# Release Notes: Metro Navigation System v1.1.5 ("Neon")

Welcome to the **v1.1.5 ("Neon")** release of the **Metro Navigation System**! This release brings significant UI refinements, standardized button layouts, a complete navigation loop cleanup, Welcome screen fixes, and coordinate mapping corrections.

## Release Metadata
- **Version**: `v1.1.5` (Codename: **Neon**)
- **Release Date**: 2026-06-26
- **Platform**: Windows (x86/x64)
- **Target Framework**: .NET Framework 4.7.2

## What's New in this Release

### 1. High Contrast & Readable UI
- **Choices Screen Descriptions**: Styled the description labels on the Options page with white, bold Segoe UI text. This fixes the visibility issue where dark gray descriptions were unreadable against the dark background.
*   **Form Sizing Constraints**: Enforced `FormBorderStyle.FixedDialog` and disabled the Maximize button on all screens. This blocks resizing, preventing the layout from getting cut off or offset when maximized.

### 2. Standardized & Equidistant Button Layouts
- **Synchronized Dimensions**: All core buttons (Back, Next, Exit, Find) have been synchronized to a standard dimension of `120 x 40` (and `Yes`/`No` buttons set to `120 x 45` to respect the aspect ratio of the underlying neon graphical assets).
- **Symmetric Spacing**: Navigation buttons at the bottom of the screens are placed at `X = 500` (Back) and `X = 640` (Next) at `Y = 500`, leaving a standard `20` pixel gap between them.
- **DPI Scaling Alignment**: Removed hardcoded coordinate positioning from the code-behind constructors. This ensures that the controls auto-scale properly under Windows High DPI text scaling settings and never get hidden or offset.

### 3. Smart Context-Aware Redirection
- **Wizard Loop**: Forward and backward navigation loops are fully established (`Welcome` -> `Choices` <-> `Stations` <-> `Map` <-> `Shortest Path` <-> `ReceiptGeneration`).
- **Options Redirection**: If a user accesses a map page or shortest route page directly from the Options screen, clicking **Back** returns them directly to the Options screen instead of forcing them back into the wizard sequence.
- **Credits Screen Back**: The Back button on the Developer Credits page always returns the user to the Options screen.

### 4. Welcome & Credits Screen Cleanup
- **Welcome Exit Button**: Introduced a flat, transparent Exit button at the bottom-right corner of the Welcome page to allow users to exit the application immediately.
- **Start Button Rendering Fix**: Resolved the duplicate background rendering on the Welcome page's Start button which caused green box clipping.
- **Credits Next Button Removal**: Hid the redundant Next button on the Credits screen and realigned the Back button to the bottom-left of the screen.
- **Receipt Next Button Removal**: Removed the Next button from the Receipt screen, making it the natural endpoint of the sequential booking wizard loop.
- **Dynamic App Version**: The Developer Credits screen now dynamically reads and displays the version number (`1.1.5`) directly from the assembly metadata instead of hardcoding it.

### 5. Stations Map Marker Correction
- Corrected the switch cases in [Stations.cs](file:///d:/University%20Projects/Metro%20Navigation%20System%20(C%23)/Stations.cs) to map each combobox station selection to its exact physical coordinates on the Karachi Metro Map background, resolving the mismatches where selecting a station would highlight the wrong coordinates.

---

## Developer Credits
Developed by **M Sufiyan Aasim**.
- **Email**: [sufiyanaasim@outlook.com](mailto:sufiyanaasim@outlook.com)
- **GitHub**: [msufiyanpk](https://github.com/msufiyanpk)
