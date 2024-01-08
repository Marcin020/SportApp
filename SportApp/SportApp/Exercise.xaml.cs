using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise : ContentPage
    {
        private ObservableCollection<string> exerciseList = new ObservableCollection<string>();

        public Exercise()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;
            Date.Text = $"{currentDate.ToString("dd-MM-yyyy")}\n{currentDate.ToString("dddd")}";
            ExerciseListView.ItemsSource = exerciseList;
        }

        private void AddExercise_Clicked(object sender, EventArgs e)
        {
            string exerciseDetails = $"{ExerciseName.Text.ToUpper()}\n kg: {ExerciseWeight.Text}, reps: {ExerciseReps.Text}, series: {ExerciseSets.Text}";


            if (!string.IsNullOrEmpty(ExerciseName.Text))
            {
                exerciseList.Add(exerciseDetails);  // Dodawanie informacji o ćwiczeniu do listy
                ClearFields();  // Czyszczenie pól wprowadzania po dodaniu ćwiczenia
            }
        }

        private void ClearFields()
        {
            ExerciseName.Text = string.Empty;
            ExerciseSets.Text = string.Empty;
            ExerciseReps.Text = string.Empty;
            ExerciseWeight.Text = string.Empty;
        }

        private void DeleteExercise_Clicked(object sender, EventArgs e)
        {
            if (ExerciseListView.SelectedItem != null)
            {
                string selectedExercise = ExerciseListView.SelectedItem.ToString();

                exerciseList.Remove(selectedExercise);

                ExerciseListView.SelectedItem = null;
            }
            else
            {
                DisplayAlert("Attention", "No exercise selected", "OK");
            }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("dd-MM-yyyy");
            App.TrainingEntries.Add(new TrainingEntry { Date = currentDate, ActivityName = "GYM" });
            Navigation.PushAsync(new Dziennik());
        }

    }
}
