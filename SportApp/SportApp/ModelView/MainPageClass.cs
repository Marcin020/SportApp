using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace SportApp
{
    internal class MainPageClass: INotifyPropertyChanged
    {
        public ICommand Login => new Command(() => Application.Current.MainPage.Navigation.PopAsync(new LoginUI()));
        public ICommand Login => new Command(() => Application.Current.MainPage.Navigation.PopAsync(new LoginUI()));

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
