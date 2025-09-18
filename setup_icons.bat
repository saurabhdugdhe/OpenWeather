@echo off
echo Setting up weather icons for OpenWeatherApp...
echo.
echo Please make sure you have:
echo 1. Downloaded the Dovora Crystal Weather Icon Pack
echo 2. Placed the 256px PNG icons in a "downloaded_icons" folder
echo.
pause

if not exist "downloaded_icons" (
    echo ERROR: "downloaded_icons" folder not found!
    echo Please create this folder and add the 256px PNG icons.
    pause
    exit /b 1
)

if not exist "OpenWeather\Resources\Images" (
    echo Creating Images directory...
    mkdir "OpenWeather\Resources\Images"
)

echo Copying and renaming icons...

if exist "downloaded_icons\sun.png" (
    copy "downloaded_icons\sun.png" "OpenWeather\Resources\Images\clear_day.png" >nul
    echo [OK] sun.png -^> clear_day.png
) else (
    echo [MISSING] sun.png
)

if exist "downloaded_icons\moon.png" (
    copy "downloaded_icons\moon.png" "OpenWeather\Resources\Images\clear_night.png" >nul
    echo [OK] moon.png -^> clear_night.png
) else (
    echo [MISSING] moon.png
)

if exist "downloaded_icons\partly-cloudy-day.png" (
    copy "downloaded_icons\partly-cloudy-day.png" "OpenWeather\Resources\Images\partly_cloudy_day.png" >nul
    echo [OK] partly-cloudy-day.png -^> partly_cloudy_day.png
) else (
    echo [MISSING] partly-cloudy-day.png
)

if exist "downloaded_icons\partly-cloudy-night.png" (
    copy "downloaded_icons\partly-cloudy-night.png" "OpenWeather\Resources\Images\partly_cloudy_night.png" >nul
    echo [OK] partly-cloudy-night.png -^> partly_cloudy_night.png
) else (
    echo [MISSING] partly-cloudy-night.png
)

if exist "downloaded_icons\cloudy.png" (
    copy "downloaded_icons\cloudy.png" "OpenWeather\Resources\Images\cloudy.png" >nul
    echo [OK] cloudy.png -^> cloudy.png
) else (
    echo [MISSING] cloudy.png
)

if exist "downloaded_icons\overcast.png" (
    copy "downloaded_icons\overcast.png" "OpenWeather\Resources\Images\overcast.png" >nul
    echo [OK] overcast.png -^> overcast.png
) else (
    echo [MISSING] overcast.png
)

if exist "downloaded_icons\drizzle.png" (
    copy "downloaded_icons\drizzle.png" "OpenWeather\Resources\Images\rain.png" >nul
    echo [OK] drizzle.png -^> rain.png
) else (
    echo [MISSING] drizzle.png
)

if exist "downloaded_icons\rain-day.png" (
    copy "downloaded_icons\rain-day.png" "OpenWeather\Resources\Images\rain_day.png" >nul
    echo [OK] rain-day.png -^> rain_day.png
) else (
    echo [MISSING] rain-day.png
)

if exist "downloaded_icons\rain-night.png" (
    copy "downloaded_icons\rain-night.png" "OpenWeather\Resources\Images\rain_night.png" >nul
    echo [OK] rain-night.png -^> rain_night.png
) else (
    echo [MISSING] rain-night.png
)

if exist "downloaded_icons\thunderstorm.png" (
    copy "downloaded_icons\thunderstorm.png" "OpenWeather\Resources\Images\thunderstorm.png" >nul
    echo [OK] thunderstorm.png -^> thunderstorm.png
) else (
    echo [MISSING] thunderstorm.png
)

if exist "downloaded_icons\snow.png" (
    copy "downloaded_icons\snow.png" "OpenWeather\Resources\Images\snow.png" >nul
    echo [OK] snow.png -^> snow.png
) else (
    echo [MISSING] snow.png
)

if exist "downloaded_icons\fog.png" (
    copy "downloaded_icons\fog.png" "OpenWeather\Resources\Images\fog.png" >nul
    echo [OK] fog.png -^> fog.png
) else (
    echo [MISSING] fog.png
)

REM Create default fallback icon
if exist "OpenWeather\Resources\Images\clear_day.png" (
    copy "OpenWeather\Resources\Images\clear_day.png" "OpenWeather\Resources\Images\weather_default.png" >nul
    echo [OK] Created weather_default.png
)

echo.
echo Setup complete! Your app now uses high-resolution weather icons.
echo Build and run your app to see the new icons in action!
echo.
pause
