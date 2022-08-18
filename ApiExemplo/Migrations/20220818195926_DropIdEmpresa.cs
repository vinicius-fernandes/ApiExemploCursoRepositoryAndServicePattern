using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiExemplo.Migrations
{
    public partial class DropIdEmpresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacoes_Empresas_EmpresaId",
                table: "Transacoes");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Transacoes");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Transacoes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacoes_Empresas_EmpresaId",
                table: "Transacoes",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacoes_Empresas_EmpresaId",
                table: "Transacoes");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Transacoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Transacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacoes_Empresas_EmpresaId",
                table: "Transacoes",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");
        }
    }
}
