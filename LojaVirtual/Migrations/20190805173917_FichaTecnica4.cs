using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class FichaTecnica4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_FichaTecnica_FichaTecnicasIdFichaTecnica",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FichaTecnica",
                table: "FichaTecnica");

            migrationBuilder.RenameTable(
                name: "FichaTecnica",
                newName: "FichaTecnicas");

            migrationBuilder.RenameColumn(
                name: "FichaTecnicasIdFichaTecnica",
                table: "Produtos",
                newName: "ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_FichaTecnicasIdFichaTecnica",
                table: "Produtos",
                newName: "IX_Produtos_ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FichaTecnicas",
                table: "FichaTecnicas",
                column: "IdFichaTecnica");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_FichaTecnicas_ProdutoId",
                table: "Produtos",
                column: "ProdutoId",
                principalTable: "FichaTecnicas",
                principalColumn: "IdFichaTecnica",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_FichaTecnicas_ProdutoId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FichaTecnicas",
                table: "FichaTecnicas");

            migrationBuilder.RenameTable(
                name: "FichaTecnicas",
                newName: "FichaTecnica");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Produtos",
                newName: "FichaTecnicasIdFichaTecnica");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_ProdutoId",
                table: "Produtos",
                newName: "IX_Produtos_FichaTecnicasIdFichaTecnica");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FichaTecnica",
                table: "FichaTecnica",
                column: "IdFichaTecnica");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_FichaTecnica_FichaTecnicasIdFichaTecnica",
                table: "Produtos",
                column: "FichaTecnicasIdFichaTecnica",
                principalTable: "FichaTecnica",
                principalColumn: "IdFichaTecnica",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
