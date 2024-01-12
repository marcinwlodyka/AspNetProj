using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class MockDataStaus2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3c6ea66-9a90-4a31-bc01-e12ef0f744ce", "AQAAAAIAAYagAAAAEFHpc9Rx7HSY/Z++iGHTOqopW99ZYiMZd7Ov8m73sse8k4cppxaaUiwJrv3T3diaQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95a2ea6f-beff-4fa2-b286-a60be562cb81", "AQAAAAIAAYagAAAAEMhm8m4qq0O3dYWL0xq7ywnZRPhyOK3g20/yB0ruKYEngq7iCHDIsCnzSdwfWC7AOQ==" });

            migrationBuilder.UpdateData(
                table: "BorrowStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(2024, 1, 11, 22, 7, 55, 586, DateTimeKind.Local).AddTicks(5782));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eccad248-124b-47d9-919b-9a117ed26bff", "AQAAAAIAAYagAAAAEP6y5qqmySoLAUYeJZZKCV4+/dGnoX8Qi8jcSKG1v3aYhw5CdAVVOd92fs2pHggvhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ac76451-df13-4434-8976-e4ef6ad3e007", "AQAAAAIAAYagAAAAECSz+qGWsWdblLUCMMv8sg44I726jfhOqmhxf3sIaWspHd3fSvEgvtt8dR0ZA5C5mQ==" });

            migrationBuilder.UpdateData(
                table: "BorrowStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
