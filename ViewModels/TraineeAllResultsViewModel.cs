using System.Collections.Generic;

namespace TraineeTrackSystem.ViewModels
{
    public class TraineeAllResultsViewModel
    {
        public string TraineeName { get; set; }
        public List<CourseResultItem> Results { get; set; }
    }

    public class CourseResultItem
    {
        public string CrsName { get; set; }
        public decimal Degree { get; set; }
        public bool Passed { get; set; }
    }
}