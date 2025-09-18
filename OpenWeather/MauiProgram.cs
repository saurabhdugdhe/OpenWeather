﻿using Microsoft.Extensions.Logging;
using WeatherApp.ViewModels;
using WeatherApp.Views;
using WeatherApp.Services;

namespace WeatherApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // Register services and view models
            builder.Services.AddSingleton<IWeatherService, OpenWeatherService>();
            builder.Services.AddSingleton<IWeatherIconMapper, WeatherIconMapper>();
            builder.Services.AddSingleton<WeatherViewModel>();
            builder.Services.AddSingleton<MainPage>();


            return builder.Build();
        }
    }
}
