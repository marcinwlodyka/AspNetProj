using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class MockDataStaus3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e571",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "3970eb39-e536-4d25-971d-a691515dd314", "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAENtnqZWAcUjdfpRvdAR/TO6yO4HaimBs89iZVxWUmMI8vfSMkprw3H6AUeepX0aPhg==", "user@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "3e726b49-dce3-4019-9b46-3e87f1526456", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEH7GF4lM3h/gvkufMo88yTotnJJfVqh3Jy2DrWMGoTiIT2B5wW7b2gwcgy7UL9OLdA==", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "BorrowStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(2024, 1, 13, 21, 47, 8, 684, DateTimeKind.Local).AddTicks(5412));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e571",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "c3c6ea66-9a90-4a31-bc01-e12ef0f744ce", "user@gmail.com", "user", "AQAAAAIAAYagAAAAEFHpc9Rx7HSY/Z++iGHTOqopW99ZYiMZd7Ov8m73sse8k4cppxaaUiwJrv3T3diaQQ==", "user" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "95a2ea6f-beff-4fa2-b286-a60be562cb81", "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEMhm8m4qq0O3dYWL0xq7ywnZRPhyOK3g20/yB0ruKYEngq7iCHDIsCnzSdwfWC7AOQ==", "admin" });

            migrationBuilder.UpdateData(
                table: "BorrowStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(2024, 1, 11, 22, 7, 55, 586, DateTimeKind.Local).AddTicks(5782));
        }
    }
}
