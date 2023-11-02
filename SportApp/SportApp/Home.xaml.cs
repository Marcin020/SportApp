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

        private async void Button_Cliked_Walk(object sender, EventArgs e) 
        {
            Navigation.PushAsync(new Trening());
        }
        private void Button_Cliked_Run(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Trening());
        }
        private void Button_Cliked_Swim(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Trening());
        }
        private void Button_Cliked_Gym(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Trening());
        }
        private void Button_Cliked_Roller(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Trening());
        }
        private void Button_Cliked_Bike(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Trening());
        }
    }
}