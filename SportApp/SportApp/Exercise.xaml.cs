using SportApp.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise : ContentPage
    {
        private readonly ObservableCollection<string> exerciseList = new ObservableCollection<string>();
        private string selectedExercise;

        public Exercise()
        {
            InitializeComponent();
            InitializeDate();
            ExerciseListView.ItemsSource = exerciseList;
        }

        private void InitializeDate()
        {
            DateTime currentDate = DateTime.Now;
            Date.Text = $"{currentDate.ToString("dd-MM-yyyy")}\n{currentDate.ToString("dddd")}";
        }

        private void AddExercise_Clicked(object sender, EventArgs e)
        {
            string exerciseDetails = $"{ExerciseName.Text.ToUpper()}\n kg: {ExerciseWeight.Text}, reps: {ExerciseReps.Text}, series: {ExerciseSets.Text}";
            if (!string.IsNullOrEmpty(ExerciseName.Text))
            {
                exerciseList.Add(exerciseDetails);
                ClearFields();
            }
        }

        private void ClearFields()
        {
            ExerciseName.Text = ExerciseSets.Text = ExerciseReps.Text = ExerciseWeight.Text = string.Empty;
        }

        private void ExerciseListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                selectedExercise = e.SelectedItem.ToString();
            }
        }

        private async void DeleteExercise_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedExercise) && exerciseList.Contains(selectedExercise))
            {
                exerciseList.Remove(selectedExercise);
                selectedExercise = null; 
            }
            else
            {
                await DisplayAlert("Attention", "No exercise selected", "OK");
            }
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var newEntry = new TrainingEntry
            {
                Date = DateTime.Now.ToString("dd.MM.yyyy"),
                DayOfWeek = DateTime.Now.DayOfWeek.ToString(),
                ActivityName = "GYM",
                Duration = "0",
                Distance = 0,
                Kcal = 0,
                ExerciseItems = new List<TrainingExercise>()
            };

            App.TrainingEntries.Add(newEntry);
            await Application.Current.MainPage.Navigation.PushAsync(new Dziennik());
        }
    }
}
