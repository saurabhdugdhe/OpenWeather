using System;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using WeatherApp.Services;

namespace WeatherApp.Converters
{
    public class WeatherIconConverter : IValueConverter
    {
        private IWeatherIconMapper _iconMapper;

        public WeatherIconConverter()
        {
            // Will be resolved when needed through the service locator
        }

        private IWeatherIconMapper GetIconMapper()
        {
            if (_iconMapper == null)
            {
                _iconMapper = Application.Current?.Handler?.MauiContext?.Services?.GetService<IWeatherIconMapper>() ?? new WeatherIconMapper();
            }
            return _iconMapper;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string iconCode)
            {
                var iconFileName = GetIconMapper().GetLocalIconPath(iconCode);
                return ImageSource.FromFile(iconFileName);
            }

            return ImageSource.FromFile("weather_default.png");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
