
namespace MauiAppHotel
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.HomeHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 700;
            window.Height = 600;

            return window;
        }
    }
}