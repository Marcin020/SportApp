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

        public string ExerciseName { get; }

        public Exercise(string selectedTraining)
        {
            InitializeComponent();
            this.selectedTraining = selectedTraining;
            UpdateActivityLabel();
        }

        public Exercise(string exerciseName, string series, string repeat, string weight) : this(exerciseName)
        {
            
            Series = series;
            Repeat = repeat;
            Weight = weight;
            ExerciseName = exerciseName;
        }

        private void UpdateActivityLabel()
        {
            trainingLabel.Text = selectedTraining;
        }

       private void OnImageButtonClicked_Plus(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new BaseExercise());
        }

        private void OnImageButtonClicked_Delete(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
