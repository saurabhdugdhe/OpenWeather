namespace WeatherApp.Services
{
    public interface IWeatherIconMapper
    {
        string GetLocalIconPath(string weatherIconCode);
    }
}
