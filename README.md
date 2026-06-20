# Metro Navigation System

Metro Navigation System is a Windows Forms desktop application for exploring metro stations, viewing the route map, calculating the shortest route between two stations, and generating trip receipts.

## Project Structure

- `Backend/` contains route calculation and trip history services.
- `Frontend/` contains UI workflow helpers used by WinForms screens.
- Root form files contain the Windows Forms screens and designer resources.
- `Resources/` contains map, background, icon, and button assets.

## Workflows

- Backend workflow: validates the route and trip-history code by compiling the project on Windows.
- Frontend workflow: validates the WinForms screens and embedded resources by compiling the same desktop application.

The repository can use separate long-lived branches named `backend` and `frontend` for focused work. Merge both into `main` after a clean build.

## Build

Open the project in Visual Studio 2022 or run:

```powershell
dotnet build "Metro App.csproj" --configuration Release
```

The application stores travel history under the executable output folder in `Metro App Travel History/`.
