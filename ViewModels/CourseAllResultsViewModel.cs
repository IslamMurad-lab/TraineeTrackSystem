using System.Collections.Generic;

namespace TraineeTrackSystem.ViewModels
{
    public class CourseAllResultsViewModel
    {
        public string CrsName { get; set; }
        public List<TraineeResultItem> Results { get; set; }
    }

    public class TraineeResultItem
    {
        public string TraineeName { get; set; }
        public decimal Degree { get; set; }
        public bool Passed { get; set; }
    }
}