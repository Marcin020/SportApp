﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        async void ToolbarItem_Cliked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginUI());
        }

        private void Button_Cliked_Walk(object sender, EventArgs e)
        {
            string selectedActivity = "Walking";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
        private void Button_Cliked_Run(object sender, EventArgs e)
        {
            string selectedActivity = "Running";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
        private void Button_Cliked_Swim(object sender, EventArgs e)
        {
            string selectedActivity = "Swimming";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
        private void Button_Cliked_Gym(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exercise());
        }
        private void Button_Cliked_Rolls(object sender, EventArgs e)
        {
            string selectedActivity = "Roller blading";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
        private void Button_Cliked_Bike(object sender, EventArgs e)
        {
            string selectedActivity = "Cycling";
            Navigation.PushAsync(new Trening(selectedActivity));
        }
    }
}