using System;
using Xamarin.Forms;

namespace SportApp
{
    public partial class Weight : ContentPage
    {
        private string _exerciseName;
        public Weight(string exerciseName)
        {
            InitializeComponent();
            this._exerciseName = exerciseName;
            exerciseLabel.Text = exerciseName;
        }

        private void PlusButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var entry = GetEntryForButton(button);

            IncreaseEntryValue(entry);
        }

        private void MinusButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var entry = GetEntryForButton(button);

            DecreaseEntryValue(entry);
        }

        private Entry GetEntryForButton(Button button)
        {
            switch (button.ClassId)
            {
                case "Series":
                    return seriesEntry;
                case "Repeat":
                    return repeatEntry;
                case "Weight":
                    return weightEntry;
                default:
                    return null;
            }
        }

        private void IncreaseEntryValue(Entry entry)
        {
            if (int.TryParse(entry.Text, out int currentValue))
            {
                entry.Text = (currentValue + 1).ToString();
            }
        }

        private void DecreaseEntryValue(Entry entry)
        {
            if (int.TryParse(entry.Text, out int currentValue))
            {
                entry.Text = (currentValue > 0) ? (currentValue - 1).ToString() : "0";
            }
        }
    }
}
