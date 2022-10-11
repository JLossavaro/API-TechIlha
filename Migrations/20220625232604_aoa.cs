using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTechIlha.Migrations
{
    public partial class aoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_clientes_ClienteId",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_funcionarios_FuncionarioId",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_TipoServico_TipoServicoId",
                table: "OrdemServico");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServico_ClienteId",
                table: "OrdemServico");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServico_TipoServicoId",
                table: "OrdemServico");

            migrationBuilder.AlterColumn<string>(
                name: "servicoNome",
                table: "TipoServico",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FuncionarioId",
                table: "OrdemServico",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "OrdemServico",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isAuthorized",
                table: "OrdemServico",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "clientes",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CPF",
                table: "clientes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_funcionarios_FuncionarioId",
                table: "OrdemServico",
                column: "FuncionarioId",
                principalTable: "funcionarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_funcionarios_FuncionarioId",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "isAuthorized",
                table: "OrdemServico");

            migrationBuilder.AlterColumn<string>(
                name: "servicoNome",
                table: "TipoServico",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "FuncionarioId",
                table: "OrdemServico",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "OrdemServico",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "clientes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "CPF",
                table: "clientes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_ClienteId",
                table: "OrdemServico",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_TipoServicoId",
                table: "OrdemServico",
                column: "TipoServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_clientes_ClienteId",
                table: "OrdemServico",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_funcionarios_FuncionarioId",
                table: "OrdemServico",
                column: "FuncionarioId",
                principalTable: "funcionarios",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_TipoServico_TipoServicoId",
                table: "OrdemServico",
                column: "TipoServicoId",
                principalTable: "TipoServico",
                principalColumn: "id");
        }
    }
}
