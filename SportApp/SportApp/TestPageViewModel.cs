using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using SportApp.Base;

namespace SportApp
{
    public class TestPageViewModel : INotifyPropertyChanged
    {
        private string _duration;
        private int _seconds;
        private int _minutes;
        private int _hours;
        private double _kcal;
        private double _distance;
        private bool _isRunning;
        private string _selectedActivity;

        public string SelectedActivity
        {
            get { return _selectedActivity; }
            set
            {
                _selectedActivity = value;
                OnPropertyChanged();
            }
        }

        public double Kcal
        {
            get { return _kcal; }
            set
            {
                _kcal = value;
                OnPropertyChanged();
            }
        }

        public double Distance
        {
            get { return _distance; }
            set
            {
                _distance = value;
                OnPropertyChanged();
            }
        }

        public double Speed
        {
            get { return _speed; }
            set
            {
                _speed = value;
                OnPropertyChanged();
            }
        }

        private double _speed;
        private double _lastDistance;
        private DateTime _lastUpdateTime;

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public TestPageViewModel()
        {
            StartTimerCommand = new Command(OnStartTimerExecute);
            StopTimerCommand = new Command(OnStopTimerExecute);
            PauseTimerCommand = new Command(OnPauseTimerExecute);
            ResetTimer();

            StartTime = TimeSpan.FromSeconds(0);
            Duration = StartTime.ToString();
        }

        private void OnStartTimerExecute(object obj)
        {
            _isRunning = true;
            Device.StartTimer(interval: TimeSpan.FromSeconds(1), () =>
            {
                if (_isRunning)
                {
                    _seconds++;
                    if (_seconds >= 60)
                    {
                        _seconds = 0;
                        _minutes++;
                        if (_minutes >= 60)
                        {
                            _minutes = 0;
                            _hours++;
                        }
                    }
                    Duration = $"{_hours:D2}:{_minutes:D2}:{_seconds:D2}";

                    double metValue = GetMetValueForActivity(SelectedActivity);
                    UpdateBurnedCalories(metValue);
                    UpdateDistance();
                }
                return _isRunning;
            });
        }

        private async void OnStopTimerExecute(object obj)
        {
            _isRunning = false;
            bool shouldStop = await Application.Current.MainPage.DisplayAlert("Finish workout", "Are you sure?", "Yes", "No");

            if (shouldStop)
            {
                var newEntry = new TrainingEntry
                {
                    Date = DateTime.Now.ToString("dd-MM-yyyy"),
                    DayOfWeek = DateTime.Now.DayOfWeek.ToString(),
                    ActivityName = SelectedActivity,
                    Duration = Duration,
                    Kcal = Kcal,
                    Distance = Distance
                };

                App.TrainingEntries.Add(newEntry);

                ResetTimer();
                ResetKcal();
                ResetDistance();

               await Application.Current.MainPage.Navigation.PushAsync(new Dziennik());
            }
            else
            {
                _isRunning = true;
            }
        }

        private void OnPauseTimerExecute(object obj)
        {
            _isRunning = false;
        }

        private void ResetTimer()
        {
            _seconds = 0;
            _minutes = 0;
            _hours = 0;
            Duration = $"{_hours:D2}:{_minutes:D2}:{_seconds:D2}";
        }

        private void ResetKcal()
        {
            Kcal = 0;
        }

        private void ResetDistance()
        {
            Distance = 0;
        }

        private double GetMetValueForActivity(string activity)
        {
            switch (activity)
            {
                case "Running":
                    return 7.0;
                case "Walking":
                    return 2.0;
                case "Roller blading":
                    return 5.0;
                case "Swimming":
                    return 5.0;
                case "Cycling":
                    return 5.0;
                default:
                    return 0.0;
            }
        }

        private void UpdateBurnedCalories(double metValue)
        {
            if (_isRunning)
            {
                double bodyWeight = 70;
                double durationInHours = _hours + _minutes / 60.0 + _seconds / 3600.0;

                Kcal = Math.Round(bodyWeight * durationInHours * metValue);
            }
        }

        private void UpdateDistance()
        {
            if (_isRunning)
            {
                double currentSpeed = GetCurrentSpeed();

                double durationInHours = _hours + _minutes / 60.0 + _seconds / 3600.0;
                Distance = Math.Round(currentSpeed * durationInHours, 2);
            }
        }

        private double GetCurrentSpeed()
        {
            try
            {
                var location = Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default)).Result;

                if (location != null)
                {
                    return (double)location.Speed;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting speed: {ex.Message}");
            }

            return 5.0; // Domyślna prędkość w m/s (możesz dostosować)
        }

        public ICommand StartTimerCommand { get; set; }
        public ICommand StopTimerCommand { get; set; }
        public ICommand PauseTimerCommand { get; set; }

        public TimeSpan StartTime { get; set; }

        public string Duration
        {
            get { return _duration; }
            set
            {
                _duration = value;
                OnPropertyChanged();
            }
        }
    }
}