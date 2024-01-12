using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class MockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    BookAuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    BookTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BookAuthors_BookAuthorId",
                        column: x => x.BookAuthorId,
                        principalTable: "BookAuthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_BookTypes_BookTypeId",
                        column: x => x.BookTypeId,
                        principalTable: "BookTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BorrowDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserId1 = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowStatuses_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowStatuses_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Joanne Murray", "Rowling" },
                    { 2, "Suzanne", "Collins" },
                    { 3, "Clive Staples", "Lewis" },
                    { 4, "Artur Conan", "Doyle" }
                });

            migrationBuilder.InsertData(
                table: "BookTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Fantasy is a genre of speculative fiction involving magical elements, typically set in a fictional universe and usually inspired by mythology or folklore. The term \"fantasy\" can also be used to describe a \"work of this genre\", usually literary.", "Fantasy" },
                    { 2, "Action fiction is a literary genre that focuses on stories that involve high-stakes, high-energy, and fast-paced events. This genre includes a wide range of subgenres, such as spy novels, adventure stories, tales of terror and intrigue (\"cloak and dagger\") and mysteries. This kind of story utilizes suspense, the tension that is built up when the reader wishes to know how the conflict between the protagonist and antagonist is going to be resolved or what the solution to the puzzle of a thriller is.", "Action" },
                    { 3, "Crime fiction, detective story, murder mystery, mystery novel, and police novel are terms used to describe narratives that centre on criminal acts and especially on the investigation, either by an amateur or a professional detective, of a crime, often a murder.", "Crime" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookAuthorId", "BookTypeId", "Description", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "You are a wizard Harry.", 20, "Harry Potter: Philosopher's Stone" },
                    { 2, 1, 1, "You are a wizard Harry again.", 100, "Harry Potter: Chamber of Secrets" },
                    { 3, 2, 2, "The Hunger Games description.", 30, "The Hunger Games" },
                    { 4, 3, 1, "For Narnia!!!!!!!!!!!!", 50, "Narnia" },
                    { 5, 4, 3, "Sherlock Holmes description.", 15, "Sherlock Holmes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookAuthorId",
                table: "Books",
                column: "BookAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookTypeId",
                table: "Books",
                column: "BookTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowStatuses_BookId",
                table: "BorrowStatuses",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowStatuses_UserId1",
                table: "BorrowStatuses",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowStatuses");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookTypes");
        }
    }
}
