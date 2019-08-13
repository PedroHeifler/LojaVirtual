using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class usuarioModificacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Logins_LoginIdLogin",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_LoginIdLogin",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "LoginIdLogin",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioIdUsuario",
                table: "Logins",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UsuarioIdUsuario",
                table: "Logins",
                column: "UsuarioIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Usuarios_UsuarioIdUsuario",
                table: "Logins",
                column: "UsuarioIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Usuarios_UsuarioIdUsuario",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Logins_UsuarioIdUsuario",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Logins");

            migrationBuilder.AddColumn<int>(
                name: "LoginIdLogin",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_LoginIdLogin",
                table: "Usuarios",
                column: "LoginIdLogin");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Logins_LoginIdLogin",
                table: "Usuarios",
                column: "LoginIdLogin",
                principalTable: "Logins",
                principalColumn: "IdLogin",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
