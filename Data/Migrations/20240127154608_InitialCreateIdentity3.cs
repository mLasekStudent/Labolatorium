using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateIdentity3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d97a05c-4a6d-4ec4-a13f-330e674e6763", "c62afc19-4f01-453d-9c30-a71cbb8b1de7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e43a785-e108-4061-b430-ef1405ec89cd", "e5327293-0b0f-4721-a4bc-8c4bb1319b49" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d97a05c-4a6d-4ec4-a13f-330e674e6763");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e43a785-e108-4061-b430-ef1405ec89cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c62afc19-4f01-453d-9c30-a71cbb8b1de7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5327293-0b0f-4721-a4bc-8c4bb1319b49");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c2b5319-23e1-4889-96a3-bc9b50b0f5a7", "1c2b5319-23e1-4889-96a3-bc9b50b0f5a7", "admin", "ADMIN" },
                    { "f4ffbc43-85b8-4c5e-b8fe-9605dafae637", "f4ffbc43-85b8-4c5e-b8fe-9605dafae637", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25b49f81-c8eb-4092-80af-a8245ba8ebad", 0, "4e6319ab-7646-4e3f-b8e4-d1da86ba8f63", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAIAAYagAAAAEPaSLjxvB0KB2kVbtPZrHue40OQH6fICehbguRBbMj4LJCDb5iacJf0nHGY7Y8VueQ==", null, false, "b79d9fb4-ad43-49d7-9e5f-1562229012be", false, "adam" },
                    { "bbbf87eb-a8c3-492c-b5c2-8163f0c574f9", 0, "c7a65de2-dbb8-4782-8556-32626b5d5aeb", "ewa@wsei.edu.pl", true, false, null, "EWA@WSEI.EDU.PL", "EWA", "AQAAAAIAAYagAAAAEJnQDUXncylUwWa/P9/hzwp+3fc2fsu8pgGEGiIl/4et2qLcCFe875EVhHqj6Qc6BA==", null, false, "adb1fd01-bac8-4217-97e2-1a7cec6185ed", false, "ewa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1c2b5319-23e1-4889-96a3-bc9b50b0f5a7", "25b49f81-c8eb-4092-80af-a8245ba8ebad" },
                    { "f4ffbc43-85b8-4c5e-b8fe-9605dafae637", "bbbf87eb-a8c3-492c-b5c2-8163f0c574f9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c2b5319-23e1-4889-96a3-bc9b50b0f5a7", "25b49f81-c8eb-4092-80af-a8245ba8ebad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4ffbc43-85b8-4c5e-b8fe-9605dafae637", "bbbf87eb-a8c3-492c-b5c2-8163f0c574f9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c2b5319-23e1-4889-96a3-bc9b50b0f5a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4ffbc43-85b8-4c5e-b8fe-9605dafae637");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25b49f81-c8eb-4092-80af-a8245ba8ebad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbbf87eb-a8c3-492c-b5c2-8163f0c574f9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d97a05c-4a6d-4ec4-a13f-330e674e6763", "0d97a05c-4a6d-4ec4-a13f-330e674e6763", "user", "USER" },
                    { "2e43a785-e108-4061-b430-ef1405ec89cd", "2e43a785-e108-4061-b430-ef1405ec89cd", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c62afc19-4f01-453d-9c30-a71cbb8b1de7", 0, "570c3aeb-1f45-4d2c-ab2b-20f42299c3ef", "ewa@wsei.edu.pl", true, false, null, "EWA@WSEI.EDU.PL", "USER", "AQAAAAIAAYagAAAAENTAuXJPRXIOoWvpLyM7JzG/kIjt3LY7rZqjW4QQtYvc85mLtsbbcSPJs7PAThKgmA==", null, false, "ea7009e7-7958-4793-85d1-feb80e648b41", false, "ewa" },
                    { "e5327293-0b0f-4721-a4bc-8c4bb1319b49", 0, "4c74b4a3-3053-4519-a41d-779e35adaef7", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAIAAYagAAAAELxNCXcDg2ONoWI1indWm1erMWbqfD71Hz5w0niGjJ1YeugCXkVhcczF0HgtvYAtnQ==", null, false, "02852807-ad77-4350-ac74-25d28c5744dd", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0d97a05c-4a6d-4ec4-a13f-330e674e6763", "c62afc19-4f01-453d-9c30-a71cbb8b1de7" },
                    { "2e43a785-e108-4061-b430-ef1405ec89cd", "e5327293-0b0f-4721-a4bc-8c4bb1319b49" }
                });
        }
    }
}
