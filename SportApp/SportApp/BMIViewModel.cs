using System;
using System.ComponentModel;
using System.Data;

namespace SportApp
{
    internal class BMIViewModel : INotifyPropertyChanged
    {
        private double height = 180;
        private double weight = 72;
        private const double STEP = 1.0;

        public double Height
        {
            get => height;
            set
            {
                height = NextStep(value);
                UpdateResults();
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                weight = NextStep(value);
                UpdateResults();
            }
        }

        public double BMI => Math.Round(Weight / Math.Pow(Height / 100, 2), 2);

        public string Classification
        {
            get
            {
                if (BMI < 18.5)
                    return "Underweight";
                if (BMI < 25)
                    return "Normal";
                if (BMI < 30)
                    return "Overweight";
                return "Obese";
            }
        }

        private void UpdateResults()
        {
            RaisePropertyChanged(nameof(BMI));
            RaisePropertyChanged(nameof(Classification));
        }

        private double NextStep(double value) => Math.Round(value / STEP) * STEP;
        private void RaisePropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
