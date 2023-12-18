using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepo.Migrations
{
    public partial class Fundoov4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labels_Note_NoteId",
                table: "Labels");

            migrationBuilder.DropIndex(
                name: "IX_Labels_NoteId",
                table: "Labels");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Labels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Labels_Id",
                table: "Labels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_Note_Id",
                table: "Labels",
                column: "Id",
                principalTable: "Note",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labels_Note_Id",
                table: "Labels");

            migrationBuilder.DropIndex(
                name: "IX_Labels_Id",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Labels");

            migrationBuilder.CreateIndex(
                name: "IX_Labels_NoteId",
                table: "Labels",
                column: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_Note_NoteId",
                table: "Labels",
                column: "NoteId",
                principalTable: "Note",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
