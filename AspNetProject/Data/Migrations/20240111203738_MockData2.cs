using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class MockData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowStatuses_AspNetUsers_UserId1",
                table: "BorrowStatuses");

            migrationBuilder.DropIndex(
                name: "IX_BorrowStatuses_UserId1",
                table: "BorrowStatuses");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "BorrowStatuses");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BorrowStatuses",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowStatuses_UserId",
                table: "BorrowStatuses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowStatuses_AspNetUsers_UserId",
                table: "BorrowStatuses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowStatuses_AspNetUsers_UserId",
                table: "BorrowStatuses");

            migrationBuilder.DropIndex(
                name: "IX_BorrowStatuses_UserId",
                table: "BorrowStatuses");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "BorrowStatuses",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "BorrowStatuses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowStatuses_UserId1",
                table: "BorrowStatuses",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowStatuses_AspNetUsers_UserId1",
                table: "BorrowStatuses",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
