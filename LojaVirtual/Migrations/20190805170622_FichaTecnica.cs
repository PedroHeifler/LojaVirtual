using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class FichaTecnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FichaTecnicaIdFichaTecnica",
                table: "Produtos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FichaTecnica",
                columns: table => new
                {
                    IdFichaTecnica = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Conteudo = table.Column<string>(nullable: true),
                    Ordem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaTecnica", x => x.IdFichaTecnica);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FichaTecnicaIdFichaTecnica",
                table: "Produtos",
                column: "FichaTecnicaIdFichaTecnica");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_FichaTecnica_FichaTecnicaIdFichaTecnica",
                table: "Produtos",
                column: "FichaTecnicaIdFichaTecnica",
                principalTable: "FichaTecnica",
                principalColumn: "IdFichaTecnica",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_FichaTecnica_FichaTecnicaIdFichaTecnica",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "FichaTecnica");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FichaTecnicaIdFichaTecnica",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FichaTecnicaIdFichaTecnica",
                table: "Produtos");
        }
    }
}
