using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class Departamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartamentoIdDepartamento",
                table: "Produtos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TpPeca = table.Column<string>(nullable: false),
                    Genero = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.IdDepartamento);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_DepartamentoIdDepartamento",
                table: "Produtos",
                column: "DepartamentoIdDepartamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Departamentos_DepartamentoIdDepartamento",
                table: "Produtos",
                column: "DepartamentoIdDepartamento",
                principalTable: "Departamentos",
                principalColumn: "IdDepartamento",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Departamentos_DepartamentoIdDepartamento",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_DepartamentoIdDepartamento",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DepartamentoIdDepartamento",
                table: "Produtos");
        }
    }
}
