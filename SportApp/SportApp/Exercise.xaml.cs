using SportApp.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise : ContentPage
    {
        private readonly ObservableCollection<string> exerciseList = new ObservableCollection<string>();
        private string selectedExercise;
        private UserInfo selectedExerciseItem;
        private List<UserInfo> myList;
        public ObservableCollection<string> ExerciseList
        {
            get { return exerciseList; }
        }
        public Exercise()
        {
            InitializeComponent();
            InitializeDate();

            myList = new List<UserInfo>
            {
                new UserInfo { Name = "Ab Crunches" },
                new UserInfo { Name = "Alternating Dumbbell Curl" },
                new UserInfo { Name = "Arnold Press" },
                new UserInfo { Name = "Assisted Pull-Ups" },
                new UserInfo { Name = "Air Squats" },
                new UserInfo { Name = "Australian Pull-Ups" },
                new UserInfo { Name = "Archer Rows" },
                new UserInfo { Name = "Alternating Side Planks" },
                new UserInfo { Name = "Alternating Heel Touches" },
                new UserInfo { Name = "Around the World Dumbbell Snatch" },
                new UserInfo { Name = "Alternating Dumbbell Bench Press" },
                new UserInfo { Name = "Alternating Dumbbell Row" },
                new UserInfo { Name = "Alternating Dumbbell Shoulder Press" },
                new UserInfo { Name = "Alternating Dumbbell Snatch" },
                new UserInfo { Name = "Alternating Dumbbell Triceps Extension" },
                new UserInfo { Name = "Air Bike" },
                new UserInfo { Name = "Barbell Squats" },
                new UserInfo { Name = "Barbell Bench Press" },
                new UserInfo { Name = "Barbell Deadlift" },
                new UserInfo { Name = "Barbell Hip Thrust" },
                new UserInfo { Name = "Barbell Row" },
                new UserInfo { Name = "Barbell Shoulder Press" },
                new UserInfo { Name = "Barbell Shrug" },
                new UserInfo { Name = "Barbell Triceps Extension" },
                new UserInfo { Name = "Bicep Curls" },
                new UserInfo { Name = "Bicycle Crunches" },
                new UserInfo { Name = "Box Jumps" },
                new UserInfo { Name = "Burpees" },
                new UserInfo { Name = "Butterfly Sit-Ups" },
                new UserInfo { Name = "Back Extensions" },
                new UserInfo { Name = "Chin-Ups" },
                new UserInfo { Name = "Cable Crunches" },
                new UserInfo { Name = "Crab Walk" },
                new UserInfo { Name = "Clapping Push-Ups" },
                new UserInfo { Name = "Deadlifts" },
                new UserInfo { Name = "Diamond Push-Ups" },
                new UserInfo { Name = "Dips" },
                new UserInfo { Name = "Dumbbell Bench Press" },
                new UserInfo { Name = "Dumbbell Bicep Curls" },
                new UserInfo { Name = "Dumbbell Deadlift" },
                new UserInfo { Name = "Dumbbell Flyes" },
                new UserInfo { Name = "Double Crunches" },
                new UserInfo { Name = "Dumbbell Lateral Raise" },
                new UserInfo { Name = "Elevated Push-Ups" },
                new UserInfo { Name = "Extended Leg Lifts" },
                new UserInfo { Name = "Face Pulls" },
                new UserInfo { Name = "Front Squats" },
                new UserInfo { Name = "Flutter Kicks" },
                new UserInfo { Name = "Front Raises" },
                new UserInfo { Name = "Front Plank" },
                new UserInfo { Name = "Glute Bridge" },
                new UserInfo { Name = "Glute Kickbacks" },
                new UserInfo { Name = "Glute-Ham Raise" },
                new UserInfo { Name = "Good Mornings" },
                new UserInfo { Name = "Hammer Curls" },
                new UserInfo { Name = "Handstand Push-Ups" },
                new UserInfo { Name = "High Knees" },
                new UserInfo { Name = "Hip Abduction" },
                new UserInfo { Name = "Hip Thrust" },
                new UserInfo { Name = "Hollow Body Hold" },
                new UserInfo { Name = "Hand Release Push-Ups" },
                new UserInfo { Name = "High Plank" },
                new UserInfo { Name = "Jumping Jacks" },
                new UserInfo { Name = "Jumping Lunges" },
                new UserInfo { Name = "Jumping Squats" },
                new UserInfo { Name = "Jumping Mountain Climbers" },
                new UserInfo { Name = "Kettlebell Swings" },
                new UserInfo { Name = "Kettlebell Squats" },
                new UserInfo { Name = "Kipping Pull-Ups" },
                new UserInfo { Name = "Knee Raises" },
                new UserInfo { Name = "Knee Push-Ups" },
                new UserInfo { Name = "Lateral Raises" },
                new UserInfo { Name = "Leg Raises" },
                new UserInfo { Name = "Leg Press" },
                new UserInfo { Name = "Leg Curls" },
                new UserInfo { Name = "Leg Extensions" },
                new UserInfo { Name = "Leg Lifts" },
                new UserInfo { Name = "Mountain Climbers" },
                new UserInfo { Name = "Muscle-Ups" },
                new UserInfo { Name = "Negative Pull-Ups" },
                new UserInfo { Name = "Overhead Press" },
                new UserInfo { Name = "Overhead Triceps Extension" },
                new UserInfo { Name = "Overhead Squats" },
                new UserInfo { Name = "One-Arm Dumbbell Row" },
                new UserInfo { Name = "One-Arm Dumbbell Shoulder Press" },
                new UserInfo { Name = "One-Arm Dumbbell Triceps Extension" },
                new UserInfo { Name = "One-Arm Dumbbell Snatch" },
                new UserInfo { Name = "Plank" },
                new UserInfo { Name = "Plank Jacks" },
                new UserInfo { Name = "Push-Ups" },
                new UserInfo { Name = "Pull-Ups" },
                new UserInfo { Name = "Plie Squats" },
                new UserInfo { Name = "Pec Deck Machine" },
                new UserInfo { Name = "Pike Push-Ups" },
                new UserInfo { Name = "Pelvic Tilts" },
                new UserInfo { Name = "Pistol Squats" },
                new UserInfo { Name = "Pallof Press" },
                new UserInfo { Name = "Pendulum Lunges" },
                new UserInfo { Name = "Pilates" },
                new UserInfo { Name = "Reverse Flyes" },
                new UserInfo { Name = "Reverse Crunches" },
                new UserInfo { Name = "Reverse Lunges" },
                new UserInfo { Name = "Russian Steps" },
                new UserInfo { Name = "Romanian Deadlifts" },
                new UserInfo { Name = "Renegade Rows" },
                new UserInfo { Name = "Reverse Plank" },
                new UserInfo { Name = "Reverse Grip Bent-Over Rows" },
                new UserInfo { Name = "Reverse Lungesx" },
                new UserInfo { Name = "Russian Twists" },
                new UserInfo { Name = "Tricep Dips" },
                new UserInfo { Name = "Tricep Extensions" },
                new UserInfo { Name = "Tricep Kickbacks" },
                new UserInfo { Name = "Tricep Pushdowns" },
                new UserInfo { Name = "Tricep Overhead Extensions" },
                new UserInfo { Name = "Tricep Rope Pushdowns" },
                new UserInfo { Name = "Tricep Skull Crushers" },
                new UserInfo { Name = "Tricep Bench Dips" },
                new UserInfo { Name = "Tricep Cable Pushdowns" },
                new UserInfo { Name = "Tricep Dumbbell Kickbacks" },
                new UserInfo { Name = "Tricep Dumbbell Overhead Extensions" },
                new UserInfo { Name = "Upright Rows" },
                new UserInfo { Name = "V-Ups" },
                new UserInfo { Name = "Wall Sit" },
                new UserInfo { Name = "Weighted Crunches" },
                new UserInfo { Name = "Weighted Dips" },
                new UserInfo { Name = "Weighted Pull-Ups" },
                new UserInfo { Name = "Weighted Push-Ups" },
                new UserInfo { Name = "Weighted Squats" },
                new UserInfo { Name = "Weighted Lunges" },
                new UserInfo { Name = "Weighted Sit-Ups" },
                new UserInfo { Name = "Weighted Step-Ups" },
                new UserInfo { Name = "Weighted Tricep Dips" },
                new UserInfo { Name = "Weighted Tricep Extensions" },
                new UserInfo { Name = "Weighted Tricep Kickbacks" }


            };

            myListView.ItemTapped += OnItemTapped;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            selectedExerciseItem = e.Item as UserInfo;

            if (selectedExerciseItem != null)
            {
                exerciseSearchBar.Text = selectedExerciseItem.Name;

                ExerciseWeight.Text = ExerciseReps.Text = ExerciseSets.Text = string.Empty;
            }
            if(sender is ListView listView)
            {
                listView.SelectedItem = null;
            }
        }


        private void myListView_Refreshing(object sender, EventArgs e)
        {
            myListView.ItemsSource = myList;
            myListView.EndRefresh();
        }

        private void OnExerciseSearchChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                myListView.ItemsSource = myList;
            }
            else
            {
                myListView.ItemsSource = myList
                    .Where(i => i.Name.ToLower().Contains(e.NewTextValue.ToLower()));
            }
        }

        private void InitializeDate()
        {
            DateTime currentDate = DateTime.Now;
            Date.Text = $"{currentDate.ToString("dd-MM-yyyy")}\n{currentDate.ToString("dddd")}";
        }

        private void AddExercise_Clicked(object sender, EventArgs e)
        {
            if (selectedExerciseItem != null)
            {
                string exerciseDetails = $"{selectedExerciseItem.Name.ToUpper()}\n kg: {ExerciseWeight.Text}, reps: {ExerciseReps.Text}, series: {ExerciseSets.Text}";

                exerciseList.Add(exerciseDetails);

                ExerciseListView.ItemsSource = exerciseList;

                ClearFields();
            }
            else
            {
                DisplayAlert("Attention", "No exercise selected", "OK");
            }
        }

        private void ClearFields()
        {
            exerciseSearchBar.Text = ExerciseSets.Text = ExerciseReps.Text = ExerciseWeight.Text = string.Empty;
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
