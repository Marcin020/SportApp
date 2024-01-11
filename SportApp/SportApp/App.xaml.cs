using System.Collections.Generic;
using Xamarin.Forms;
using SportApp.Base;

namespace SportApp
{
    public partial class App : Application
    {
        public static List<TrainingEntry> TrainingEntries { get; set; } = new List<TrainingEntry>();
        public App()
        {
            Device.SetFlags(new string[] { "AppTheme_Experimental" });
            InitializeComponent();

            MainPage = new NavigationPage(new Exercise());
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
