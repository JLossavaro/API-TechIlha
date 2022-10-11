using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTechIlha.Migrations
{
    public partial class gf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_clientes_clienteid",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_funcionarios_funcionarioid",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_TipoServico_tiposervicoid",
                table: "OrdemServico");

            migrationBuilder.RenameColumn(
                name: "tiposervicoid",
                table: "OrdemServico",
                newName: "TipoServicoId");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "OrdemServico",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "imei",
                table: "OrdemServico",
                newName: "Imei");

            migrationBuilder.RenameColumn(
                name: "funcionarioid",
                table: "OrdemServico",
                newName: "FuncionarioId");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "OrdemServico",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "OrdemServico",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "clienteid",
                table: "OrdemServico",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "OrdemServico",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_tiposervicoid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_TipoServicoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_funcionarioid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_clienteid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_ClienteId");

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

            migrationBuilder.RenameColumn(
                name: "TipoServicoId",
                table: "OrdemServico",
                newName: "tiposervicoid");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "OrdemServico",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Imei",
                table: "OrdemServico",
                newName: "imei");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "OrdemServico",
                newName: "funcionarioid");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "OrdemServico",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "OrdemServico",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "OrdemServico",
                newName: "clienteid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrdemServico",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_TipoServicoId",
                table: "OrdemServico",
                newName: "IX_OrdemServico_tiposervicoid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_FuncionarioId",
                table: "OrdemServico",
                newName: "IX_OrdemServico_funcionarioid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_ClienteId",
                table: "OrdemServico",
                newName: "IX_OrdemServico_clienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_clientes_clienteid",
                table: "OrdemServico",
                column: "clienteid",
                principalTable: "clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_funcionarios_funcionarioid",
                table: "OrdemServico",
                column: "funcionarioid",
                principalTable: "funcionarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_TipoServico_tiposervicoid",
                table: "OrdemServico",
                column: "tiposervicoid",
                principalTable: "TipoServico",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
