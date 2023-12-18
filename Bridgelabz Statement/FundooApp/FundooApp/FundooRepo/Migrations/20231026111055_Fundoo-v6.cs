using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepo.Migrations
{
    public partial class Fundoov6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collobrator",
                columns: table => new
                {
                    CollabId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteId = table.Column<int>(nullable: false),
                    SenderUserId = table.Column<int>(nullable: false),
                    ReceiverUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collobrator", x => x.CollabId);
                    table.ForeignKey(
                        name: "FK_Collobrator_Note_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Note",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Collobrator_NoteId",
                table: "Collobrator",
                column: "NoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Collobrator");
        }
    }
}
