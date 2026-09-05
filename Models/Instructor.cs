namespace TraineeTrackSystem.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public int Dept_Id { get; set; }

        public virtual Department Department { get; set; }
    }
}