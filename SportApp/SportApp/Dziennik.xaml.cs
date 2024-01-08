using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SportApp.Base;
using System.Collections.ObjectModel;

namespace SportApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Dziennik : ContentPage
    {
        public ObservableCollection<string> dziennikList { get; set; }

        public Dziennik()
        {
            InitializeComponent();

            dziennikList = new ObservableCollection<string>();

            DziennikList.ItemsSource = dziennikList;

            foreach (var entry in App.TrainingEntries)
            {
                if(entry.ActivityName != "GYM")
                {
                    dziennikList.Add($"{entry.Date} {entry.DayOfWeek.ToUpper()} \n {entry.ActivityName.ToUpper()} \n time:{entry.Duration} kcal:{entry.Kcal} km:{entry.Distance}");
                }
                else
                {
                    dziennikList.Add($"{entry.Date} {entry.DayOfWeek.ToUpper()} \n {entry.ActivityName.ToUpper()} ");
                }
                
            }
        }
    }

}