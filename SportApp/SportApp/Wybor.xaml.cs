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
    public partial class Wybor : ContentPage
    {
        private string selectedTraining;

        public Wybor()
        {
            InitializeComponent();
        }

        private void UpperBody(object sender, EventArgs e)
        {
            selectedTraining = "Upper Body";
        }

        private void LowerBody(object sender, EventArgs e)
        {
            selectedTraining = "Lower Body";
        }

        private void FBW(object sender, EventArgs e)
        {
            selectedTraining = "Full Body Workout";
        }
        private async void OnButtonClicked_Next(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise(selectedTraining));
        }
    }
}
