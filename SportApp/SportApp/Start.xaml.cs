using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start : ContentPage
    {
        public Start()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked_Start(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}