using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace SportApp
{
    public class TestPageViewModel : INotifyPropertyChanged
    {
        private string _duration;
        private int _seconds;
        private int _minutes;
        private int _hours;
        private bool _isRunning;


        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        //[NotifyPropertyChangedInvocator]
        
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
                if(_isRunning)
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
                }
                return _isRunning;
            });
        }

        private async void OnStopTimerExecute(object obj)
        {
            _isRunning = false;
            bool shouldStop = await Application.Current.MainPage.DisplayAlert("Finish workout","Are you sure?", "Yes", "No");
            if(shouldStop)
            {
                ResetTimer();
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
