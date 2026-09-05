namespace TraineeTrackSystem.Models
{
    public class CrsResult
    {
        public int Id { get; set; }

        public decimal Degree { get; set; }

        public int Crs_Id { get; set; }

        public int Trainee_Id { get; set; }

        public virtual Course Course { get; set; }

        public virtual Trainee Trainee { get; set; }
    }
}