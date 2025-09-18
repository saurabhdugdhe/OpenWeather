using WeatherApp.Views;

namespace WeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        //public App(MainPage mainPage)
        //{
        //    InitializeComponent();
        //    MainPage = mainPage;
        //}

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}