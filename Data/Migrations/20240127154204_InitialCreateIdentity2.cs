using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateIdentity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43431c20-91d8-4f49-ac2f-450fe14da4bc", "4c02bbc3-dcc8-4582-8427-706b724e0447" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7df10054-d762-47d5-ae08-a273bd35b7d6", "aebe392d-615b-4adf-b5e4-f63ba1915c7e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43431c20-91d8-4f49-ac2f-450fe14da4bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7df10054-d762-47d5-ae08-a273bd35b7d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c02bbc3-dcc8-4582-8427-706b724e0447");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aebe392d-615b-4adf-b5e4-f63ba1915c7e");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "43431c20-91d8-4f49-ac2f-450fe14da4bc", "43431c20-91d8-4f49-ac2f-450fe14da4bc", "admin", "ADMIN" },
                    { "7df10054-d762-47d5-ae08-a273bd35b7d6", "7df10054-d762-47d5-ae08-a273bd35b7d6", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c02bbc3-dcc8-4582-8427-706b724e0447", 0, "62a45cb4-ede9-4cca-9d45-5c9f5a13e5b2", "adam@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEE8fae4nr6PrR9KHUImEO/8VkyGNcmCugyiwIiejXVTQvs30JvGvKv0XWi2ykj3TTg==", null, false, "a7483df1-e8c1-482c-9641-d7e73377a993", false, "adam" },
                    { "aebe392d-615b-4adf-b5e4-f63ba1915c7e", 0, "e5965598-28df-4de9-8deb-b007d532ae21", "ewa@wsei.edu.pl", true, false, null, null, "USER", "AQAAAAIAAYagAAAAEKGGPIEg9+HlqvEiwRaLF8i9cW7Y6C/q5x1SH7OizlGha6h8Thf+OyhdJSkBWHGhsg==", null, false, "6981d7ee-9e4b-4b1c-b25b-448443283cb1", false, "ewa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "43431c20-91d8-4f49-ac2f-450fe14da4bc", "4c02bbc3-dcc8-4582-8427-706b724e0447" },
                    { "7df10054-d762-47d5-ae08-a273bd35b7d6", "aebe392d-615b-4adf-b5e4-f63ba1915c7e" }
                });
        }
    }
}
