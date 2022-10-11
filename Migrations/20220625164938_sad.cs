using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiTechIlha.Migrations
{
    public partial class sad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_clientes_clienteId",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_funcionarios_funcionarioId",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_Modelo_modeloId",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_TipoServico_tipoServicoid",
                table: "OrdemServico");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServico_modeloId",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "modeloId",
                table: "OrdemServico");

            migrationBuilder.RenameColumn(
                name: "tipoServicoid",
                table: "OrdemServico",
                newName: "tiposervicoid");

            migrationBuilder.RenameColumn(
                name: "funcionarioId",
                table: "OrdemServico",
                newName: "funcionarioid");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "OrdemServico",
                newName: "clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_tipoServicoid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_tiposervicoid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_funcionarioId",
                table: "OrdemServico",
                newName: "IX_OrdemServico_funcionarioid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_clienteId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "tipoServicoid");

            migrationBuilder.RenameColumn(
                name: "funcionarioid",
                table: "OrdemServico",
                newName: "funcionarioId");

            migrationBuilder.RenameColumn(
                name: "clienteid",
                table: "OrdemServico",
                newName: "clienteId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_tiposervicoid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_tipoServicoid");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_funcionarioid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_funcionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemServico_clienteid",
                table: "OrdemServico",
                newName: "IX_OrdemServico_clienteId");

            migrationBuilder.AddColumn<int>(
                name: "modeloId",
                table: "OrdemServico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    marca = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_modeloId",
                table: "OrdemServico",
                column: "modeloId");

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
                name: "FK_OrdemServico_Modelo_modeloId",
                table: "OrdemServico",
                column: "modeloId",
                principalTable: "Modelo",
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
    }
}
