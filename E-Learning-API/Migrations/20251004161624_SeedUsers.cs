using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Learning_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "Name", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 4, 19, 16, 22, 831, DateTimeKind.Local).AddTicks(568), "alice.johnson@example.com", "Alice Johnson", "Instructor", new DateTime(2025, 10, 4, 19, 16, 22, 833, DateTimeKind.Local).AddTicks(8380) },
                    { 2, new DateTime(2025, 10, 4, 19, 16, 22, 833, DateTimeKind.Local).AddTicks(9495), "bob.smith@example.com", "Bob Smith", "Student", new DateTime(2025, 10, 4, 19, 16, 22, 833, DateTimeKind.Local).AddTicks(9509) },
                    { 3, new DateTime(2025, 10, 4, 19, 16, 22, 833, DateTimeKind.Local).AddTicks(9512), "charlie.brown@example.com", "Charlie Brown", "Student", new DateTime(2025, 10, 4, 19, 16, 22, 833, DateTimeKind.Local).AddTicks(9513) },
                    { 4, new DateTime(2025, 10, 4, 19, 16, 22, 833, DateTimeKind.Local).AddTicks(9515), "diana.prince@example.com", "Diana Prince", "Admin", new DateTime(2025, 10, 4, 19, 16, 22, 833, DateTimeKind.Local).AddTicks(9516) },
                    { 5, new DateTime(2025, 10, 4, 19, 16, 22, 833, DateTimeKind.Local).AddTicks(9518), "ethan.hunt@example.com", "Ethan Hunt", "Instructor", new DateTime(2025, 10, 4, 19, 16, 22, 833, DateTimeKind.Local).AddTicks(9519) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);
        }
    }
}
