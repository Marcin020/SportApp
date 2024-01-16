using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Trening : ContentPage
    {

        private TestPageViewModel _viewModel;

        public string selectedActivity = "Aktywność";

        public Trening()
        {
            InitializeComponent();
            UpdateActivityLabel();
            _viewModel = new TestPageViewModel();
            BindingContext = _viewModel;
        }

        public Trening(string activity) : this()
        {
            _viewModel.SelectedActivity = activity;
            selectedActivity = activity;
            UpdateActivityLabel();
        }

        private void UpdateActivityLabel()
        {
            activityLabel.Text = selectedActivity;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Rozpocznij nasłuchiwanie zmian w prędkości i dystansie po pojawieniu się strony
            MessagingCenter.Subscribe<TestPageViewModel, double>(this, "SpeedUpdated", (sender, speed) =>
            {
                _viewModel.Speed = speed;
            });

            MessagingCenter.Subscribe<TestPageViewModel, double>(this, "DistanceUpdated", (sender, distance) =>
            {
                _viewModel.Distance = distance;
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            // Zatrzymaj nasłuchiwanie po zniknięciu strony
            MessagingCenter.Unsubscribe<TestPageViewModel, double>(this, "SpeedUpdated");
            MessagingCenter.Unsubscribe<TestPageViewModel, double>(this, "DistanceUpdated");
        }



        public ICommand StartTimerCommand { get; set; }


    }
}
