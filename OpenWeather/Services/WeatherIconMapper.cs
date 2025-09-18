using System.Collections.Generic;

namespace WeatherApp.Services
{
    public class WeatherIconMapper : IWeatherIconMapper
    {
        private readonly Dictionary<string, string> _iconMappings;

        public WeatherIconMapper()
        {
            _iconMappings = new Dictionary<string, string>
            {
                // Clear sky
                { "01d", "clear_day.png" },
                { "01n", "clear_night.png" },
                
                // Few clouds
                { "02d", "partly_cloudy_day.png" },
                { "02n", "partly_cloudy_night.png" },
                
                // Scattered clouds
                { "03d", "cloudy.png" },
                { "03n", "cloudy.png" },
                
                // Broken clouds
                { "04d", "overcast.png" },
                { "04n", "overcast.png" },
                
                // Shower rain
                { "09d", "rain.png" },
                { "09n", "rain.png" },
                
                // Rain
                { "10d", "rain_day.png" },
                { "10n", "rain_night.png" },
                
                // Thunderstorm
                { "11d", "thunderstorm.png" },
                { "11n", "thunderstorm.png" },
                
                // Snow
                { "13d", "snow.png" },
                { "13n", "snow.png" },
                
                // Mist
                { "50d", "fog.png" },
                { "50n", "fog.png" }
            };
        }

        public string GetLocalIconPath(string weatherIconCode)
        {
            if (string.IsNullOrEmpty(weatherIconCode))
                return "weather_default.png";

            return _iconMappings.TryGetValue(weatherIconCode, out string iconFileName) 
                ? iconFileName 
                : "weather_default.png";
        }
    }
}
