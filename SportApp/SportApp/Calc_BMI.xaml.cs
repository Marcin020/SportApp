using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calc_BMI : ContentPage
    {
        public Calc_BMI()
        {
            InitializeComponent();
            BindingContext = new BMIViewModel();
        }
    }
}