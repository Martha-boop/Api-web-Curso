using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class heroisBatalhasIndentidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HErois_Batalhas_BatalhaID",
                table: "HErois");

            migrationBuilder.DropIndex(
                name: "IX_HErois_BatalhaID",
                table: "HErois");

            migrationBuilder.DropColumn(
                name: "BatalhaID",
                table: "HErois");

            migrationBuilder.CreateTable(
                name: "HeroiBatalhas",
                columns: table => new
                {
                    HeroiId = table.Column<int>(type: "int", nullable: false),
                    BatalhaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroiBatalhas", x => new { x.BatalhaID, x.HeroiId });
                    table.ForeignKey(
                        name: "FK_HeroiBatalhas_Batalhas_BatalhaID",
                        column: x => x.BatalhaID,
                        principalTable: "Batalhas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroiBatalhas_HErois_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "HErois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndentidadeSecretas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeReal = table.Column<int>(type: "int", nullable: false),
                    HeroiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndentidadeSecretas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndentidadeSecretas_HErois_HeroiId",
                        column: x => x.HeroiId,
                        principalTable: "HErois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroiBatalhas_HeroiId",
                table: "HeroiBatalhas",
                column: "HeroiId");

            migrationBuilder.CreateIndex(
                name: "IX_IndentidadeSecretas_HeroiId",
                table: "IndentidadeSecretas",
                column: "HeroiId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroiBatalhas");

            migrationBuilder.DropTable(
                name: "IndentidadeSecretas");

            migrationBuilder.AddColumn<int>(
                name: "BatalhaID",
                table: "HErois",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HErois_BatalhaID",
                table: "HErois",
                column: "BatalhaID");

            migrationBuilder.AddForeignKey(
                name: "FK_HErois_Batalhas_BatalhaID",
                table: "HErois",
                column: "BatalhaID",
                principalTable: "Batalhas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
