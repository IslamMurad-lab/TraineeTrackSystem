namespace TraineeTrackSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Degree { get; set; }

        public decimal MinDegree { get; set; }

        public int Dept_Id { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<CrsResult> CrsResults { get; set; }
    }
}