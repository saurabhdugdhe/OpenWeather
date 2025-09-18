## WeatherApp (.NET MAUI)

A cross-platform weather app built with .NET MAUI that fetches current conditions from OpenWeatherMap. Runs on Android, iOS, Windows, and MacCatalyst.

### Features
- **Current conditions**: temperature, description, and icon by city name
- **Architecture**: MVVM with dependency injection
- **Crisp UI**: local high-resolution weather icons
- **Cross-platform**: Android, iOS, Windows, MacCatalyst, Tizen

### Project structure
```
WeatherApp/
├─ OpenWeather/                  # MAUI project
│  ├─ Views/                     # UI pages (e.g., MainPage)
│  ├─ ViewModels/                # MVVM view models (e.g., WeatherViewModel)
│  ├─ Models/                    # Data models (e.g., WeatherData)
│  ├─ Services/                  # API + icon mapping services
│  ├─ Resources/Images/          # App images + weather icons
│  ├─ Platforms/                 # Platform-specific glue
│  └─ MauiProgram.cs             # App DI and configuration
├─ OpenWeather.sln               # Solution
├─ WEATHER_ICONS_SETUP.md        # Icon setup guide
├─ setup_icons.bat               # Windows icon helper
└─ setup_weather_icons.ps1       # PowerShell icon helper
```

### Prerequisites
- **OS**: Windows 10/11 or macOS (for iOS/MacCatalyst)
- **SDK**: .NET SDK 9.0+
- **Workloads**: .NET MAUI workloads installed
  - CLI: `dotnet workload install maui` (plus Android/iOS/Mac as needed)
  - Visual Studio 2022 17.8+ with ".NET Multi-platform App UI development"
- **API key**: OpenWeatherMap account and API key (`https://openweathermap.org/api`)

### Setup
- **Clone**
```bash
git clone <your-fork-or-repo-url>
cd WeatherApp
```
- **Add your OpenWeather API key**
  - Quick start: edit `OpenWeather/Services/OpenWeatherService.cs` and replace the `ApiKey` constant value.
  - Recommended: load the key from secure storage or platform secrets; avoid committing real keys.
- **Optional: set up high-resolution icons**
  - PowerShell (Windows):
```powershell
./setup_weather_icons.ps1
```
  - CMD:
```bat
setup_icons.bat
```
  - Details in `WEATHER_ICONS_SETUP.md`.

### Run
- **Visual Studio**
  - Open `OpenWeather.sln`
  - Select target platform (Android/iOS/Windows/MacCatalyst)
  - Press Run (F5)

- **CLI**
  - Restore and build:
```bash
dotnet restore OpenWeather/WeatherApp.csproj
dotnet build OpenWeather/WeatherApp.csproj
```
  - Run per target (examples):
    - Windows:
```bash
dotnet build OpenWeather/WeatherApp.csproj -t:Run -f net9.0-windows10.0.19041.0
```
    - Android (emulator/device required):
```bash
dotnet build OpenWeather/WeatherApp.csproj -t:Run -f net9.0-android
```
    - MacCatalyst (on macOS):
```bash
dotnet build OpenWeather/WeatherApp.csproj -t:Run -f net9.0-maccatalyst
```
    - iOS (on macOS, with provisioning):
```bash
dotnet build OpenWeather/WeatherApp.csproj -t:Run -f net9.0-ios
```

### Configuration
- **API endpoint**: `https://api.openweathermap.org/data/2.5/weather`
- **Units**: metric by default; adjust in `OpenWeather/Services/OpenWeatherService.cs` if needed
- **DI**: see `OpenWeather/MauiProgram.cs` for service registrations

### Security notes
- **Do not commit** real API keys. Prefer user secrets, environment variables, or platform-specific secure storage.
- **Rotate keys** if exposed.

### Troubleshooting
- **Workloads**: `dotnet workload restore` or `dotnet workload install maui`
- **Android**: start an emulator in Android Device Manager before running
- **iOS/MacCatalyst**: requires macOS with Xcode and provisioning
- **401/403**: verify API key and account plan
- **Missing icons**: rerun icon setup script; check `OpenWeather/Resources/Images/`

### Credits
- **Weather data**: OpenWeatherMap
- **Framework**: .NET MAUI

### License
No explicit license. If open-sourcing, consider adding a `LICENSE` file (e.g., MIT).
