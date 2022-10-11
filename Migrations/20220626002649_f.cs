using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTechIlha.Migrations
{
    public partial class f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_funcionarios_FuncionarioId",
                table: "OrdemServico");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServico_FuncionarioId",
                table: "OrdemServico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_FuncionarioId",
                table: "OrdemServico",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_funcionarios_FuncionarioId",
                table: "OrdemServico",
                column: "FuncionarioId",
                principalTable: "funcionarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
