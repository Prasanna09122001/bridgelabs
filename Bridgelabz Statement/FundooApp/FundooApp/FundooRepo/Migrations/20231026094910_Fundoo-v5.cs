using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepo.Migrations
{
    public partial class Fundoov5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labels_Note_Id",
                table: "Labels");

            migrationBuilder.AlterColumn<int>(
                name: "NoteId",
                table: "Labels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Labels_NoteId",
                table: "Labels",
                column: "NoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_Register_Id",
                table: "Labels",
                column: "Id",
                principalTable: "Register",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_Note_NoteId",
                table: "Labels",
                column: "NoteId",
                principalTable: "Note",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labels_Register_Id",
                table: "Labels");

            migrationBuilder.DropForeignKey(
                name: "FK_Labels_Note_NoteId",
                table: "Labels");

            migrationBuilder.DropIndex(
                name: "IX_Labels_NoteId",
                table: "Labels");

            migrationBuilder.AlterColumn<int>(
                name: "NoteId",
                table: "Labels",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_Note_Id",
                table: "Labels",
                column: "Id",
                principalTable: "Note",
                principalColumn: "NoteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
