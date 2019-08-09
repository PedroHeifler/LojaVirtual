using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class ficha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichaTecnicas_Produtos_ProdutoId",
                table: "FichaTecnicas");

            migrationBuilder.DropIndex(
                name: "IX_FichaTecnicas_ProdutoId",
                table: "FichaTecnicas");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "FichaTecnicas");

            migrationBuilder.AlterColumn<string>(
                name: "TpUsuario",
                table: "Logins",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ficha",
                table: "FichaTecnicas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutosIdProduto",
                table: "FichaTecnicas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FichaTecnicas_ProdutosIdProduto",
                table: "FichaTecnicas",
                column: "ProdutosIdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_FichaTecnicas_Produtos_ProdutosIdProduto",
                table: "FichaTecnicas",
                column: "ProdutosIdProduto",
                principalTable: "Produtos",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FichaTecnicas_Produtos_ProdutosIdProduto",
                table: "FichaTecnicas");

            migrationBuilder.DropIndex(
                name: "IX_FichaTecnicas_ProdutosIdProduto",
                table: "FichaTecnicas");

            migrationBuilder.DropColumn(
                name: "Ficha",
                table: "FichaTecnicas");

            migrationBuilder.DropColumn(
                name: "ProdutosIdProduto",
                table: "FichaTecnicas");

            migrationBuilder.AlterColumn<string>(
                name: "TpUsuario",
                table: "Logins",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "FichaTecnicas",
                nullable: false,
                defaultValue: 0);

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
    }
}
