using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class MockDataUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f441", null, "user", "user" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "c7f78cb1-770d-4801-bf5b-f3dd1aa426be", true, "AQAAAAIAAYagAAAAEAmmY5jLNm8l/Gfffq8NT8/0bqQ4APUg5Amh0N29y8wnVdffMs3GdPwWuUncL6qAag==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e571", 0, "d34e60fa-92d4-4d46-b624-80eb420b120e", "IdentityUser", "user@gmail.com", true, false, null, "user@gmail.com", "user", "AQAAAAIAAYagAAAAEBESWP449mE6vmFY/zzGFZSBLmSHLDarlrcE7pERaG43RDWp0HyFxKrTGNjyBavrpw==", null, false, "", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f441", "a18be9c0-aa65-4af8-bd17-00bd9344e571" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad376a8f-9eab-4bb9-9fca-30b01540f441", "a18be9c0-aa65-4af8-bd17-00bd9344e571" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f441");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e571");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "c50141db-33c4-4db5-b3eb-1d4ccb683416", false, "AQAAAAIAAYagAAAAELujJ9l+3yzk0/nk0ytssUexZR70RVqC9vR5UxPovVzPGSXibgP1+F6/nUvRxmyLmg==" });
        }
    }
}
