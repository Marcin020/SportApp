using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SportApp.Base
{
    public class TrainingEntry
    {
        public string Date { get; set; }
        public string ActivityName { get; set; }
        public ObservableCollection<string> Exercises { get; set; } = new ObservableCollection<string>();
    }
}
