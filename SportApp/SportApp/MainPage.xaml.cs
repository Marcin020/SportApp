using System;
using System.Collections.Generic;
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

        public IEnumerable<object> ExerciseItem { get; internal set; }

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
