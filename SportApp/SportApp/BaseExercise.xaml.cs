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
	public partial class BaseExercise : ContentPage
	{
		public BaseExercise ()
		{
			InitializeComponent ();
		}
	}
    private async void OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item != null)
        {
            // Resetuj kolory dla wszystkich elementów listy
            foreach (var item in (sender as ListView).ItemsSource)
            {
                var viewCell = (sender as ListView).ItemTemplate.CreateContent() as ViewCell;
                var label = viewCell.View.FindByName<Label>("ExerciseLabel");

                if (label != null)
                {
                    label.TextColor = Color.Black;
                }
            }

            // Ustaw kolor dla wybranego elementu
            var selectedLabel = (e.Item as string);
            var selectedViewCell = (sender as ListView).ItemTemplate.CreateContent() as ViewCell;
            var selectedLabelView = selectedViewCell.View.FindByName<Label>("exerciseLabel");

            if (selectedLabelView != null)
            {
                selectedLabelView.TextColor = Color.Red; // Tutaj ustaw kolor, jaki chcesz
            }

            // Przekaż nazwę ćwiczenia do Weight Page
            await NavigationPage.PushAsync(new Weight(selectedLabel));

            // Zatrzymaj zdarzenie od propagowania dalej
            (sender as ListView).SelectedItem = null;
        }
    }
}