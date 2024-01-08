using SportApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    public partial class DziennikDetailPage : ContentPage
    {
        public TrainingEntry SelectedTrainingEntry { get; set; }

        public DziennikDetailPage(TrainingEntry entry)
        {
            InitializeComponent();
            SelectedTrainingEntry = entry;
            LoadExercises();
        }

        private void LoadExercises()
        {
            ExerciseListView.ItemsSource = SelectedTrainingEntry.Exercises;
        }
    }
}