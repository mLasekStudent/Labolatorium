using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateLaby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64fb31a7-6444-49f1-a6aa-27a220103077", "2679460b-2acc-47ed-8af3-21bf7f0de78a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e0d53b65-8ee8-4f05-84ca-7b0c0a12d113", "5002decf-9d44-4ceb-af2d-6ce44fa1a2eb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64fb31a7-6444-49f1-a6aa-27a220103077");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0d53b65-8ee8-4f05-84ca-7b0c0a12d113");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2679460b-2acc-47ed-8af3-21bf7f0de78a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5002decf-9d44-4ceb-af2d-6ce44fa1a2eb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "506baa16-af0e-4394-aa25-d5fde0794c3b", "506baa16-af0e-4394-aa25-d5fde0794c3b", "admin", "ADMIN" },
                    { "bacab883-5845-4ce3-8ba2-45358fa1b2d7", "bacab883-5845-4ce3-8ba2-45358fa1b2d7", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "373595e8-cd49-4ce9-8c57-749fbf616979", 0, "96b604b3-caea-4389-8177-17934ba84459", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAIAAYagAAAAEEm1A6GYp32rtlUCyL8rqx/DtitCA8pRBN5pA7rDYRduwBtL2qILpFtWjGyiqoL2Jw==", null, false, "a20f4b4b-70f4-4e58-adb3-65670fc4768f", false, "adam" },
                    { "a9e1de0a-6a67-4a82-a11f-3c84c128a644", 0, "82bd301e-01e6-4b54-b706-8357a9792a49", "ewa@wsei.edu.pl", true, false, null, "EWA@WSEI.EDU.PL", "EWA", "AQAAAAIAAYagAAAAEFPo6e2YW3yy2lCVp5rt7Ot/IKrkaNhtZnXtLa77JwdnwK5tHKnPeBcW7OFa/E3Yag==", null, false, "6cd0efa1-a7ee-40db-bd39-e444742a470a", false, "ewa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "506baa16-af0e-4394-aa25-d5fde0794c3b", "373595e8-cd49-4ce9-8c57-749fbf616979" },
                    { "bacab883-5845-4ce3-8ba2-45358fa1b2d7", "a9e1de0a-6a67-4a82-a11f-3c84c128a644" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "506baa16-af0e-4394-aa25-d5fde0794c3b", "373595e8-cd49-4ce9-8c57-749fbf616979" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bacab883-5845-4ce3-8ba2-45358fa1b2d7", "a9e1de0a-6a67-4a82-a11f-3c84c128a644" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "506baa16-af0e-4394-aa25-d5fde0794c3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bacab883-5845-4ce3-8ba2-45358fa1b2d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "373595e8-cd49-4ce9-8c57-749fbf616979");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9e1de0a-6a67-4a82-a11f-3c84c128a644");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64fb31a7-6444-49f1-a6aa-27a220103077", "64fb31a7-6444-49f1-a6aa-27a220103077", "user", "USER" },
                    { "e0d53b65-8ee8-4f05-84ca-7b0c0a12d113", "e0d53b65-8ee8-4f05-84ca-7b0c0a12d113", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2679460b-2acc-47ed-8af3-21bf7f0de78a", 0, "9901e0e5-c305-4d3c-8f7d-b0aa57c47016", "ewa@wsei.edu.pl", true, false, null, "EWA@WSEI.EDU.PL", "EWA", "AQAAAAIAAYagAAAAEBwCpyodVx6pkbe6xFg8C0eOFrOtsQ/aNl6099LctgoOlYFOUlhbq/tH9Plevjs1Pg==", null, false, "9d437409-0948-4e2b-b96e-d7f71a559c69", false, "ewa" },
                    { "5002decf-9d44-4ceb-af2d-6ce44fa1a2eb", 0, "d58b2e0b-aadf-47ee-99d0-88c91be01254", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAIAAYagAAAAEEl159Y9uMNG7BEuBG2A1BzvWfCzH53/sWMb/QAH2uNwacNw5rdlfsM+dYIwFkpc1Q==", null, false, "068ec3bf-7f3d-41ab-9430-e1e600ff997c", false, "adam" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "64fb31a7-6444-49f1-a6aa-27a220103077", "2679460b-2acc-47ed-8af3-21bf7f0de78a" },
                    { "e0d53b65-8ee8-4f05-84ca-7b0c0a12d113", "5002decf-9d44-4ceb-af2d-6ce44fa1a2eb" }
                });
        }
    }
}
