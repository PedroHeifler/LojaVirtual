using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class UsuarioEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Enderecos_EnderecoIdEndereco",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EnderecoIdEndereco",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EnderecoIdEndereco",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "Rua",
                table: "Enderecos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuariosIdUsuario",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_UsuariosIdUsuario",
                table: "Enderecos",
                column: "UsuariosIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Usuarios_UsuariosIdUsuario",
                table: "Enderecos",
                column: "UsuariosIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Usuarios_UsuariosIdUsuario",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_UsuariosIdUsuario",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "UsuariosIdUsuario",
                table: "Enderecos");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoIdEndereco",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EnderecoIdEndereco",
                table: "Usuarios",
                column: "EnderecoIdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Enderecos_EnderecoIdEndereco",
                table: "Usuarios",
                column: "EnderecoIdEndereco",
                principalTable: "Enderecos",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
