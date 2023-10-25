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
        private async void ToolbarItem_Cliked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginUI)}");
        }

        private void ImageButton_Spacer(object sender, EventArgs e) 
        {
            Navigation.PushAsync(new Page3());
        }
    }
}