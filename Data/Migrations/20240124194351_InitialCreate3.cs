using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "Id", "Adres", "Cena", "Data", "Miasto", "Pokój", "Właściciel" },
                values: new object[,]
                {
                    { 1, "Miodowa 2", 399.00m, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kraków", 24, "Robert Makłowicz" },
                    { 2, "Masztowa 4", 449.00m, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gdańsk", 9, "Krzysztof Krawczyk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
