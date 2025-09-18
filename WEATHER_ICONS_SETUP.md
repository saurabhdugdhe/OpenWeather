# Weather Icons Setup Guide 🌤️

Your OpenWeatherApp is now configured to use high-resolution local weather icons instead of OpenWeatherMap's low-resolution web icons.

## 🎯 Quick Setup (5 minutes)

### Step 1: Download Icons
1. Go to: **https://www.dovora.com/resources/weather-icons/**
2. Download the **"Crystal Weather Icon Pack"** (free)
3. Extract the ZIP file
4. Navigate to: `PNG → 256px` folder

### Step 2: Automated Setup (Recommended)
1. Create a `downloaded_icons` folder next to the setup scripts
2. Copy all 256px PNG icons into `downloaded_icons/`
3. Choose your preferred method:
   
   **PowerShell (recommended):**
   ```powershell
   .\setup_weather_icons.ps1
   ```
   
   **Batch file:**
   ```cmd
   .\setup_icons.bat
   ```

### Step 3: Manual Setup (Alternative)
Copy and rename the following icons to `OpenWeather/Resources/Images/`:

| Download Name | Rename To |
|---------------|-----------|
| `sun.png` | `clear_day.png` |
| `moon.png` | `clear_night.png` |
| `partly-cloudy-day.png` | `partly_cloudy_day.png` |
| `partly-cloudy-night.png` | `partly_cloudy_night.png` |
| `cloudy.png` | `cloudy.png` |
| `overcast.png` | `overcast.png` |
| `drizzle.png` | `rain.png` |
| `rain-day.png` | `rain_day.png` |
| `rain-night.png` | `rain_night.png` |
| `thunderstorm.png` | `thunderstorm.png` |
| `snow.png` | `snow.png` |
| `fog.png` | `fog.png` |
| `sun.png` (copy) | `weather_default.png` |

## 🚀 Test Your Setup

1. Build and run your app
2. Search for any city
3. You should see beautiful high-resolution weather icons!

## 🎨 Alternative Icon Sources (if needed)

- **Icons8**: https://icons8.com/icons/set/weather
- **Flaticon**: https://flaticon.com/free-icons/weather
- **SVGStack**: https://svgstack.com/collections/weather-icon-set

## 📱 What's Changed in Your App

- ✅ Icons are now 256x256px (vs 64x64px from OpenWeatherMap)
- ✅ Crisp display on all devices and screen densities
- ✅ Consistent modern design
- ✅ No internet dependency for icons
- ✅ Day/night variations for better UX

---

*Delete this file once setup is complete.*
