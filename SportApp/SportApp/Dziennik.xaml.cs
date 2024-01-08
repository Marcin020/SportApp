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

            // Inicjalizacja ObservableCollection
            dziennikList = new ObservableCollection<string>();

            // Przypisz źródło danych do ListView
            DziennikList.ItemsSource = dziennikList;

            // Tutaj możesz dodać kod do wczytania istniejących wpisów z pamięci lub innych źródeł danych
            // Na przykład, jeśli masz listę z App.TrainingEntries, możesz ją tutaj przetworzyć i dodać do dziennikList
            foreach (var entry in App.TrainingEntries)
            {
                dziennikList.Add($"{entry.Date} - {entry.ActivityName}");
            }
        }
        private void DziennikList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is TrainingEntry selectedEntry)
            {
                Navigation.PushAsync(new DziennikDetailPage(selectedEntry));
            }
        }
    }

}