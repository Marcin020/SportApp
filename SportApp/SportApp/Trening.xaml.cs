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

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Trening : ContentPage
    {
        public Trening()
        {
            InitializeComponent();
        }

        private void Button_Cliked_Go(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home());
        }
    }
}
