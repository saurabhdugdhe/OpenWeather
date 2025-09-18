using WeatherApp.ViewModels;

namespace WeatherApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(WeatherViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
