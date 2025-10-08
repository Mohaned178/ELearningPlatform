using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Learning_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatefas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "C# Basics", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "Build web applications with ASP.NET Core.", "ASP.NET Core", new DateTime(2024, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Progress", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, 1, 50.0, 2, null },
                    { 2, 2, 20.0, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "LessonId", "Content", "CourseId", "SequenceNumber", "Title" },
                values: new object[,]
                {
                    { 1, "C# syntax, variables, and data types.", 1, 1, "Introduction to C#" },
                    { 2, "If statements, loops, and switch cases.", 1, 2, "Control Flow" },
                    { 3, "Setting up your first ASP.NET Core project.", 2, 1, "ASP.NET Core Setup" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "CourseId", "CreatedAt", "Rating", "UpdatedAt", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, "Great course!", 1, new DateTime(2024, 2, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 2, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 2, null },
                    { 2, "Very informative.", 2, new DateTime(2024, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 2, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "LessonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 7, 23, 45, 14, 758, DateTimeKind.Utc).AddTicks(9273), "Introduction to C#", new DateTime(2025, 10, 7, 23, 45, 14, 758, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 10, 7, 23, 45, 14, 758, DateTimeKind.Utc).AddTicks(9595), "Build APIs with ASP.NET Core.", "ASP.NET Core Web API", new DateTime(2025, 10, 7, 23, 45, 14, 758, DateTimeKind.Utc).AddTicks(9595) });
        }
    }
}
