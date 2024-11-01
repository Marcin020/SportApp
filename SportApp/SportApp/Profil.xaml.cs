﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profil : ContentPage
    {
        public Profil()
        {
            InitializeComponent();
        }
        async void Button_Cliked_BMI(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calc_BMI());
        }
        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            if (e.Value)
            {
                App.Current.UserAppTheme = OSAppTheme.Dark;
            }
            else
            {
                App.Current.UserAppTheme = OSAppTheme.Light;
            }
        }
    }
}