using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SportApp.Base;

namespace SportApp.Base
{
    public class TrainingEntry
    {
        public string Date { get; set; }
        public string DayOfWeek { get; set; }
        public string ActivityName { get; set; }
       
        public string Duration { get; set; } 
        public double Kcal { get; set; } 
        public double Distance { get; set; }

        public List<TrainingExercise> ExerciseItems { get; set; } = new List<TrainingExercise>();

    }
}
