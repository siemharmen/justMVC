using Microsoft.EntityFrameworkCore.Migrations;

namespace ReversiMVC.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpelID = table.Column<int>(type: "int", nullable: true),
                    Row00 = table.Column<int>(type: "int", nullable: false),
                    Row01 = table.Column<int>(type: "int", nullable: false),
                    Row02 = table.Column<int>(type: "int", nullable: false),
                    Row03 = table.Column<int>(type: "int", nullable: false),
                    Row04 = table.Column<int>(type: "int", nullable: false),
                    Row05 = table.Column<int>(type: "int", nullable: false),
                    Row06 = table.Column<int>(type: "int", nullable: false),
                    Row07 = table.Column<int>(type: "int", nullable: false),
                    Row10 = table.Column<int>(type: "int", nullable: false),
                    Row11 = table.Column<int>(type: "int", nullable: false),
                    Row12 = table.Column<int>(type: "int", nullable: false),
                    Row13 = table.Column<int>(type: "int", nullable: false),
                    Row14 = table.Column<int>(type: "int", nullable: false),
                    Row15 = table.Column<int>(type: "int", nullable: false),
                    Row16 = table.Column<int>(type: "int", nullable: false),
                    Row17 = table.Column<int>(type: "int", nullable: false),
                    Row20 = table.Column<int>(type: "int", nullable: false),
                    Row21 = table.Column<int>(type: "int", nullable: false),
                    Row22 = table.Column<int>(type: "int", nullable: false),
                    Row23 = table.Column<int>(type: "int", nullable: false),
                    Row24 = table.Column<int>(type: "int", nullable: false),
                    Row25 = table.Column<int>(type: "int", nullable: false),
                    Row26 = table.Column<int>(type: "int", nullable: false),
                    Row27 = table.Column<int>(type: "int", nullable: false),
                    Row30 = table.Column<int>(type: "int", nullable: false),
                    Row31 = table.Column<int>(type: "int", nullable: false),
                    Row32 = table.Column<int>(type: "int", nullable: false),
                    Row33 = table.Column<int>(type: "int", nullable: false),
                    Row34 = table.Column<int>(type: "int", nullable: false),
                    Row35 = table.Column<int>(type: "int", nullable: false),
                    Row36 = table.Column<int>(type: "int", nullable: false),
                    Row37 = table.Column<int>(type: "int", nullable: false),
                    Row40 = table.Column<int>(type: "int", nullable: false),
                    Row41 = table.Column<int>(type: "int", nullable: false),
                    Row42 = table.Column<int>(type: "int", nullable: false),
                    Row43 = table.Column<int>(type: "int", nullable: false),
                    Row44 = table.Column<int>(type: "int", nullable: false),
                    Row45 = table.Column<int>(type: "int", nullable: false),
                    Row46 = table.Column<int>(type: "int", nullable: false),
                    Row47 = table.Column<int>(type: "int", nullable: false),
                    Row50 = table.Column<int>(type: "int", nullable: false),
                    Row51 = table.Column<int>(type: "int", nullable: false),
                    Row52 = table.Column<int>(type: "int", nullable: false),
                    Row53 = table.Column<int>(type: "int", nullable: false),
                    Row54 = table.Column<int>(type: "int", nullable: false),
                    Row55 = table.Column<int>(type: "int", nullable: false),
                    Row56 = table.Column<int>(type: "int", nullable: false),
                    Row57 = table.Column<int>(type: "int", nullable: false),
                    Row60 = table.Column<int>(type: "int", nullable: false),
                    Row61 = table.Column<int>(type: "int", nullable: false),
                    Row62 = table.Column<int>(type: "int", nullable: false),
                    Row63 = table.Column<int>(type: "int", nullable: false),
                    Row64 = table.Column<int>(type: "int", nullable: false),
                    Row65 = table.Column<int>(type: "int", nullable: false),
                    Row66 = table.Column<int>(type: "int", nullable: false),
                    Row67 = table.Column<int>(type: "int", nullable: false),
                    Row70 = table.Column<int>(type: "int", nullable: false),
                    Row71 = table.Column<int>(type: "int", nullable: false),
                    Row72 = table.Column<int>(type: "int", nullable: false),
                    Row73 = table.Column<int>(type: "int", nullable: false),
                    Row74 = table.Column<int>(type: "int", nullable: false),
                    Row75 = table.Column<int>(type: "int", nullable: false),
                    Row76 = table.Column<int>(type: "int", nullable: false),
                    Row77 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boards_Spellen_SpelID",
                        column: x => x.SpelID,
                        principalTable: "Spellen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boards_SpelID",
                table: "Boards",
                column: "SpelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boards");
        }
    }
}
