using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }

        private void Button_Clicked_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginUI());
        }

        private void Button_Cliked_Rejestracja(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Rejestracja());
        }
    }
}
