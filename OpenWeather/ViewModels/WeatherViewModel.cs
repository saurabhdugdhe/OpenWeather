using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        private readonly IWeatherService _weatherService;
        private WeatherData _weatherData;
        private string _city;
        private bool _isLoading;

        public WeatherViewModel(IWeatherService weatherService)
        {
            _weatherService = weatherService;
            FetchWeatherCommand = new Command(async () => await FetchWeatherAsync());
        }

        public WeatherData WeatherData
        {
            get => _weatherData;
            set
            {
                _weatherData = value;
                OnPropertyChanged();
            }
        }

        public string City
        {
            get => _city;
            set
           {
                _city = value;
                OnPropertyChanged();
            }
        }

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }

        public ICommand FetchWeatherCommand { get; }

        private async Task FetchWeatherAsync()
        {
            if (string.IsNullOrWhiteSpace(City))
                return;

            IsLoading = true;
            WeatherData = await _weatherService.GetWeatherAsync(City);
            IsLoading = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}