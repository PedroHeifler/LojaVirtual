using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class Endereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Usuarios_UsuariosIdUsuario",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "UsuariosIdUsuario",
                table: "Enderecos",
                newName: "UsuarioIdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_UsuariosIdUsuario",
                table: "Enderecos",
                newName: "IX_Enderecos_UsuarioIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Usuarios_UsuarioIdUsuario",
                table: "Enderecos",
                column: "UsuarioIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Usuarios_UsuarioIdUsuario",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "UsuarioIdUsuario",
                table: "Enderecos",
                newName: "UsuariosIdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_UsuarioIdUsuario",
                table: "Enderecos",
                newName: "IX_Enderecos_UsuariosIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Usuarios_UsuariosIdUsuario",
                table: "Enderecos",
                column: "UsuariosIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
