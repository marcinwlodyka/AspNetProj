using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class MockDataStaus4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f441",
                column: "NormalizedName",
                value: "USER");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "NormalizedName",
                value: "ADMIN");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55d77988-ffe5-4cdf-92b2-91bb709a8403", "AQAAAAIAAYagAAAAEPmO5F6q4u2arY96P5ICiWSL389l007LIGijfK+5GMmbnWUsgqQmpyXpAKWtKn8CNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37cae977-02a7-4539-9cf5-50e0d11ab868", "AQAAAAIAAYagAAAAEDv6lQJN3QOYYz28hiGpOzDAlGTgAYjFDQ9c6eclW1O7XjthBS2KnEL35/dzvuMIeQ==" });

            migrationBuilder.UpdateData(
                table: "BorrowStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(2024, 1, 13, 21, 53, 1, 850, DateTimeKind.Local).AddTicks(3461));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f441",
                column: "NormalizedName",
                value: "user");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "NormalizedName",
                value: "admin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3970eb39-e536-4d25-971d-a691515dd314", "AQAAAAIAAYagAAAAENtnqZWAcUjdfpRvdAR/TO6yO4HaimBs89iZVxWUmMI8vfSMkprw3H6AUeepX0aPhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e726b49-dce3-4019-9b46-3e87f1526456", "AQAAAAIAAYagAAAAEH7GF4lM3h/gvkufMo88yTotnJJfVqh3Jy2DrWMGoTiIT2B5wW7b2gwcgy7UL9OLdA==" });

            migrationBuilder.UpdateData(
                table: "BorrowStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(2024, 1, 13, 21, 47, 8, 684, DateTimeKind.Local).AddTicks(5412));
        }
    }
}
