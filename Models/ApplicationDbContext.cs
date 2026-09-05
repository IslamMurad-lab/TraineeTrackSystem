using Microsoft.EntityFrameworkCore;

namespace TraineeTrackSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Instructor -> Department
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_Id);

            // Trainee -> Department
            modelBuilder.Entity<Trainee>()
                .HasOne(t => t.Department)
                .WithMany(d => d.Trainees)
                .HasForeignKey(t => t.Dept_Id);

            // Course -> Department
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.Dept_Id);

            // CrsResult -> Course
            modelBuilder.Entity<CrsResult>()
                .HasOne(r => r.Course)
                .WithMany(c => c.CrsResults)
                .HasForeignKey(r => r.Crs_Id)
                .OnDelete(DeleteBehavior.NoAction);

            // CrsResult -> Trainee
            modelBuilder.Entity<CrsResult>()
                .HasOne(r => r.Trainee)
                .WithMany(t => t.CrsResults)
                .HasForeignKey(r => r.Trainee_Id)
                .OnDelete(DeleteBehavior.NoAction);

            // ================= Seed Data =================
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Software Engineering", Manager = "Ahmed Ali" },
                new Department { Id = 2, Name = "Networks", Manager = "Sara Mostafa" }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { Id = 1, Name = "Mona Khaled", Image = "mona.jpg", Salary = 15000, Address = "Cairo", Dept_Id = 1 },
                new Instructor { Id = 2, Name = "Karim Adel", Image = "karim.jpg", Salary = 18000, Address = "Giza", Dept_Id = 2 }
            );

            modelBuilder.Entity<Trainee>().HasData(
                new Trainee { Id = 1, Name = "Youssef Hassan", Image = "youssef.jpg", Address = "Tanta", Grade = 0, Dept_Id = 1 },
                new Trainee { Id = 2, Name = "Mariam Adel", Image = "mariam.jpg", Address = "Mansoura", Grade = 0, Dept_Id = 2 },
                new Trainee { Id = 3, Name = "Omar Saeed", Image = "omar.jpg", Address = "Cairo", Dept_Id = 1 }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "ASP.NET MVC", Degree = 100, MinDegree = 50, Dept_Id = 1 },
                new Course { Id = 2, Name = "Networking Basics", Degree = 100, MinDegree = 60, Dept_Id = 2 },
                new Course { Id = 3, Name = "Database Systems", Degree = 100, MinDegree = 50, Dept_Id = 1 }
            );

            modelBuilder.Entity<CrsResult>().HasData(
                new CrsResult { Id = 1, Degree = 75, Crs_Id = 1, Trainee_Id = 1 },
                new CrsResult { Id = 2, Degree = 40, Crs_Id = 1, Trainee_Id = 2 },
                new CrsResult { Id = 3, Degree = 55, Crs_Id = 2, Trainee_Id = 1 },
                new CrsResult { Id = 4, Degree = 90, Crs_Id = 3, Trainee_Id = 3 }
            );
        }
    }
}