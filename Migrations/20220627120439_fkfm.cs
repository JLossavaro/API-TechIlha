using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTechIlha.Migrations
{
    public partial class fkfm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "data",
                table: "Venda",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "valor",
                table: "Venda",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "valorTotal",
                table: "Venda",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "isPayed",
                table: "OrdemServico",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "valor",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "valorTotal",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "isPayed",
                table: "OrdemServico");
        }
    }
}
