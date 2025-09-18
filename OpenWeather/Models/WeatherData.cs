namespace WeatherApp.Models
{
    public class WeatherData
    {
        public Main Main { get; set; }
        public Weather[] Weather { get; set; }
        public Wind Wind { get; set; }
        public string Name { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
        public float Feels_like { get; set; }
        public int Humidity { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Wind
    {
        public float Speed { get; set; }
    }
}
