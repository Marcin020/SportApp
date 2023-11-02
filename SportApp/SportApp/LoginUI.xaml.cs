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
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            if (txtUsername.Text == "admin" && txtPassword.Text == "12345")
            {
                Navigation.PushAsync(new Menu());
            }
            else
            {
                DisplayAlert("Ostrzeżenie", "Login lub hasło jest niepoprawne", "Ok");
            }
        }

    }
}