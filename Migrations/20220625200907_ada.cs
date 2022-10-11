using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTechIlha.Migrations
{
    public partial class ada : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "TipoServicoId",
                table: "OrdemServico",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "TipoServicoId",
                table: "OrdemServico",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
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

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_clientes_ClienteId",
                table: "OrdemServico",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_funcionarios_FuncionarioId",
                table: "OrdemServico",
                column: "FuncionarioId",
                principalTable: "funcionarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_TipoServico_TipoServicoId",
                table: "OrdemServico",
                column: "TipoServicoId",
                principalTable: "TipoServico",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
