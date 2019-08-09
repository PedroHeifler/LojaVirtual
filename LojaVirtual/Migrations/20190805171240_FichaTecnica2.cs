using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class FichaTecnica2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_FichaTecnica_FichaTecnicaIdFichaTecnica",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "FichaTecnicaIdFichaTecnica",
                table: "Produtos",
                newName: "FichaTecnicasIdFichaTecnica");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_FichaTecnicaIdFichaTecnica",
                table: "Produtos",
                newName: "IX_Produtos_FichaTecnicasIdFichaTecnica");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_FichaTecnica_FichaTecnicasIdFichaTecnica",
                table: "Produtos",
                column: "FichaTecnicasIdFichaTecnica",
                principalTable: "FichaTecnica",
                principalColumn: "IdFichaTecnica",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_FichaTecnica_FichaTecnicasIdFichaTecnica",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "FichaTecnicasIdFichaTecnica",
                table: "Produtos",
                newName: "FichaTecnicaIdFichaTecnica");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_FichaTecnicasIdFichaTecnica",
                table: "Produtos",
                newName: "IX_Produtos_FichaTecnicaIdFichaTecnica");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_FichaTecnica_FichaTecnicaIdFichaTecnica",
                table: "Produtos",
                column: "FichaTecnicaIdFichaTecnica",
                principalTable: "FichaTecnica",
                principalColumn: "IdFichaTecnica",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
