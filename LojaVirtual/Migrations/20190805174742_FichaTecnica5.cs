using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class FichaTecnica5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_FichaTecnicas_ProdutoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ProdutoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Produtos");

            migrationBuilder.CreateIndex(
                name: "IX_FichaTecnicas_ProdutoId",
                table: "FichaTecnicas",
                column: "ProdutoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FichaTecnicas_Produtos_ProdutoId",
                table: "FichaTecnicas",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichaTecnicas_Produtos_ProdutoId",
                table: "FichaTecnicas");

            migrationBuilder.DropIndex(
                name: "IX_FichaTecnicas_ProdutoId",
                table: "FichaTecnicas");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Produtos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ProdutoId",
                table: "Produtos",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_FichaTecnicas_ProdutoId",
                table: "Produtos",
                column: "ProdutoId",
                principalTable: "FichaTecnicas",
                principalColumn: "IdFichaTecnica",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
