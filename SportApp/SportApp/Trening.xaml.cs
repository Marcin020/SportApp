using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Timers;
using System.Windows.Input;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Trening : ContentPage
    {

        private TestPageViewModel _viewModel;

        private string selectedActivity = "Aktywność";
        
        public Trening()
        {
            InitializeComponent();
            UpdateActivityLabel();
            _viewModel = new TestPageViewModel();
            BindingContext = _viewModel;
        }

        public Trening(string activity) : this()
        {
            selectedActivity = activity;
            UpdateActivityLabel();
        }

        private void UpdateActivityLabel()
        {
            activityLabel.Text = selectedActivity;
        }

        public ICommand StartTimerCommand { get; set; }

        
    }
}
