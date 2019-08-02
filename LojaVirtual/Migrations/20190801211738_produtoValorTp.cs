using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class produtoValorTp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Produtos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TpProduto",
                table: "Produtos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Produtos",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TpProduto",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Produtos");

            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
