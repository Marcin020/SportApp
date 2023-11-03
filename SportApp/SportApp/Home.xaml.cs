using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private void ToolbarItem_Cliked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Button_Cliked_Walk(object sender, EventArgs e) 
        {
            string selectedActivity = "Walking";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
        private void Button_Cliked_Run(object sender, EventArgs e)
        {
            string selectedActivity = "Running";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
        private void Button_Cliked_Swim(object sender, EventArgs e)
        {
            string selectedActivity = "Swimming";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
        private void Button_Cliked_Gym(object sender, EventArgs e)
        {
            string selectedActivity = "Gym";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
        private void Button_Cliked_Rolls(object sender, EventArgs e)
        {
            string selectedActivity = "Roller blading";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
        private void Button_Cliked_Bike(object sender, EventArgs e)
        {
            string selectedActivity = "Cycling";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
    }
}