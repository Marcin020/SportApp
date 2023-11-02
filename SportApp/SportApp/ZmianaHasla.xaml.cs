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
    public partial class ZmianaHasla : ContentPage
    {
        public ZmianaHasla()
        {
            InitializeComponent();
        }

        private void ButtonCliked_ChangePassword(object sender, EventArgs e)
        {
            try
            {
                string password = TxtPassword.Text;
                string confirmPass = TxtConfirm.Text;
                if(string.IsNullOrEmpty(password))
                {
                    DisplayAlert("Change Password", "Please type password","Ok");
                }
            }
            catch (Exception ex) 
            {

            }
        }
    }
}