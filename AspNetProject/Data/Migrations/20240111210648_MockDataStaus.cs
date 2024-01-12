using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class MockDataStaus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "BorrowStatuses",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

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

            migrationBuilder.InsertData(
                table: "BorrowStatuses",
                columns: new[] { "Id", "BookId", "BorrowDate", "ReturnDate", "UserId" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "a18be9c0-aa65-4af8-bd17-00bd9344e571" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BorrowStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "BorrowStatuses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e571",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d34e60fa-92d4-4d46-b624-80eb420b120e", "AQAAAAIAAYagAAAAEBESWP449mE6vmFY/zzGFZSBLmSHLDarlrcE7pERaG43RDWp0HyFxKrTGNjyBavrpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7f78cb1-770d-4801-bf5b-f3dd1aa426be", "AQAAAAIAAYagAAAAEAmmY5jLNm8l/Gfffq8NT8/0bqQ4APUg5Amh0N29y8wnVdffMs3GdPwWuUncL6qAag==" });
        }
    }
}
