using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise : ContentPage
    {
        public string selectedTraining;

        public string Series { get; }
        public string Repeat { get; }
        public string Weight { get; }

        public Exercise(string selectedTraining)
        {
            InitializeComponent();
            this.selectedTraining = selectedTraining;
            UpdateActivityLabel();
        }

        public Exercise(string selectedTraining, string series, string repeat, string weight) : this(selectedTraining)
        {
            Series = series;
            Repeat = repeat;
            Weight = weight;
        }

        private void UpdateActivityLabel()
        {
            trainingLabel.Text = selectedTraining;
        }

        private async void OnImageButtonClicked_Plus(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BaseExercise());
        }
    }
}
