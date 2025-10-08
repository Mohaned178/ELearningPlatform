using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Learning_API.Migrations
{
    /// <inheritdoc />
    public partial class newEra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CreatedAt", "Description", "InstructorId", "InstructorId1", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 7, 23, 45, 14, 758, DateTimeKind.Utc).AddTicks(9273), "Learn the basics of C# programming.", 1, null, "Introduction to C#", new DateTime(2025, 10, 7, 23, 45, 14, 758, DateTimeKind.Utc).AddTicks(9439) },
                    { 2, new DateTime(2025, 10, 7, 23, 45, 14, 758, DateTimeKind.Utc).AddTicks(9595), "Build APIs with ASP.NET Core.", 1, null, "ASP.NET Core Web API", new DateTime(2025, 10, 7, 23, 45, 14, 758, DateTimeKind.Utc).AddTicks(9595) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);
        }
    }
}
