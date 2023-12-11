using Xamarin.Forms;

namespace SportApp
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "AppTheme_Experimental" });
            InitializeComponent();

            MainPage = new NavigationPage(new Wybor());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
