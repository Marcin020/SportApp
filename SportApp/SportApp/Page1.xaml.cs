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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void ToolbarItem_Cliked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Button_Cliked_Walk(object sender, EventArgs e) 
        {
            Navigation.PushAsync(new Page3());
        }
        private void Button_Cliked_Run(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
        private void Button_Cliked_Swim(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
        private void Button_Cliked_Gym(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
        private void Button_Cliked_Roller(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
        private void Button_Cliked_Bike(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}