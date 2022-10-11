using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTechIlha.Migrations
{
    public partial class gd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_clientes_Clienteid",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_funcionarios_Funcionarioid",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_TipoServico_TipoServicoid",
                table: "OrdemServico");

            migrationBuilder.RenameColumn(
                name: "TipoServicoid",
                table: "OrdemServico",
                newName: "tipoServicoid");

            migrationBuilder.RenameColumn(
                name: "Funcionarioid",
                table: "OrdemServico",
                newName: "funcionarioId");

            migrationBuilder.RenameColumn(
                name: "Clienteid",
                table: "OrdemServico",
                newName: "clienteId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_TipoServicoid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_tipoServicoid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_Funcionarioid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_funcionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_Clienteid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_clienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_clientes_clienteId",
                table: "OrdemServico",
                column: "clienteId",
                principalTable: "clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_funcionarios_funcionarioId",
                table: "OrdemServico",
                column: "funcionarioId",
                principalTable: "funcionarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_TipoServico_tipoServicoid",
                table: "OrdemServico",
                column: "tipoServicoid",
                principalTable: "TipoServico",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_clientes_clienteId",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_funcionarios_funcionarioId",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_TipoServico_tipoServicoid",
                table: "OrdemServico");

            migrationBuilder.RenameColumn(
                name: "tipoServicoid",
                table: "OrdemServico",
                newName: "TipoServicoid");

            migrationBuilder.RenameColumn(
                name: "funcionarioId",
                table: "OrdemServico",
                newName: "Funcionarioid");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "OrdemServico",
                newName: "Clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_tipoServicoid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_TipoServicoid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_funcionarioId",
                table: "OrdemServico",
                newName: "IX_OrdemServico_Funcionarioid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_clienteId",
                table: "OrdemServico",
                newName: "IX_OrdemServico_Clienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_clientes_Clienteid",
                table: "OrdemServico",
                column: "Clienteid",
                principalTable: "clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_funcionarios_Funcionarioid",
                table: "OrdemServico",
                column: "Funcionarioid",
                principalTable: "funcionarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_TipoServico_TipoServicoid",
                table: "OrdemServico",
                column: "TipoServicoid",
                principalTable: "TipoServico",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
