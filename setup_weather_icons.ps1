# Weather Icons Setup Script
# Run this script after downloading the Dovora Crystal Weather Icon Pack
# Place the extracted PNG/256px icons in a "downloaded_icons" folder next to this script

param(
    [string]$SourcePath = "downloaded_icons",
    [string]$TargetPath = "OpenWeather/Resources/Images"
)

Write-Host "Setting up weather icons for OpenWeatherApp..." -ForegroundColor Green

# Create target directory if it doesn't exist
if (!(Test-Path $TargetPath)) {
    New-Item -ItemType Directory -Path $TargetPath -Force
}

# Icon mapping from Dovora names to our required names
$iconMappings = @{
    "sun.png" = "clear_day.png"
    "moon.png" = "clear_night.png"
    "partly-cloudy-day.png" = "partly_cloudy_day.png"
    "partly-cloudy-night.png" = "partly_cloudy_night.png"
    "cloudy.png" = "cloudy.png"
    "overcast.png" = "overcast.png"
    "drizzle.png" = "rain.png"
    "rain-day.png" = "rain_day.png"
    "rain-night.png" = "rain_night.png"
    "thunderstorm.png" = "thunderstorm.png"
    "snow.png" = "snow.png"
    "fog.png" = "fog.png"
}

# Copy and rename icons
foreach ($mapping in $iconMappings.GetEnumerator()) {
    $sourcePath = Join-Path $SourcePath $mapping.Key
    $targetPath = Join-Path $TargetPath $mapping.Value
    
    if (Test-Path $sourcePath) {
        Copy-Item $sourcePath $targetPath -Force
        Write-Host "[OK] $($mapping.Key) -> $($mapping.Value)" -ForegroundColor Green
    } else {
        Write-Host "[MISSING] $($mapping.Key)" -ForegroundColor Red
    }
}

# Create a default fallback icon (copy from clear_day.png)
$fallbackSource = Join-Path $TargetPath "clear_day.png"
$fallbackTarget = Join-Path $TargetPath "weather_default.png"
if (Test-Path $fallbackSource) {
    Copy-Item $fallbackSource $fallbackTarget -Force
    Write-Host "[OK] Created weather_default.png" -ForegroundColor Green
}

Write-Host "`nSetup complete! Your app now uses high-resolution weather icons." -ForegroundColor Cyan
Write-Host "Build and run your app to see the new icons in action!" -ForegroundColor Yellow
