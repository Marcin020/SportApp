﻿using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
