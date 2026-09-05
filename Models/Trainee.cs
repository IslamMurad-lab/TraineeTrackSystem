namespace TraineeTrackSystem.Models
{
    public class Trainee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Address { get; set; }

        public decimal Grade { get; set; }

        public int Dept_Id { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<CrsResult> CrsResults { get; set; }
    }
}