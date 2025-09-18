using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class OpenWeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "a6e66a68ec9df3b4cf8b34c33a0a4cd7"; // Replace with your API key
        private const string ApiUrl = "https://api.openweathermap.org/data/2.5/weather";

        public OpenWeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            var url = $"{ApiUrl}?q={city}&appid={ApiKey}&units=metric";
            var response = await _httpClient.GetAsync(url).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var weather = JsonSerializer.Deserialize<WeatherData>(json, options);
                return weather;
            }

            return null;
        }
    }
}
