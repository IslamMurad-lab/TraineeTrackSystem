using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TraineeTrackSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Manager", "Name" },
                values: new object[,]
                {
                    { 1, "Ahmed Ali", "Software Engineering" },
                    { 2, "Sara Mostafa", "Networks" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Degree", "Dept_Id", "MinDegree", "Name" },
                values: new object[,]
                {
                    { 1, 100m, 1, 50m, "ASP.NET MVC" },
                    { 2, 100m, 2, 60m, "Networking Basics" },
                    { 3, 100m, 1, 50m, "Database Systems" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Address", "Dept_Id", "Image", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Cairo", 1, "mona.jpg", "Mona Khaled", 15000m },
                    { 2, "Giza", 2, "karim.jpg", "Karim Adel", 18000m }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Address", "Dept_Id", "Grade", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Tanta", 1, 0m, "youssef.jpg", "Youssef Hassan" },
                    { 2, "Mansoura", 2, 0m, "mariam.jpg", "Mariam Adel" },
                    { 3, "Cairo", 1, 0m, "omar.jpg", "Omar Saeed" }
                });

            migrationBuilder.InsertData(
                table: "CrsResults",
                columns: new[] { "Id", "Crs_Id", "Degree", "Trainee_Id" },
                values: new object[,]
                {
                    { 1, 1, 75m, 1 },
                    { 2, 1, 40m, 2 },
                    { 3, 2, 55m, 1 },
                    { 4, 3, 90m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CrsResults",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
