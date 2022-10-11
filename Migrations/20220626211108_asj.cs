using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTechIlha.Migrations
{
    public partial class asj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nomeProduto",
                table: "Venda",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "produtos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "produtos");

            migrationBuilder.AlterColumn<string>(
                name: "nomeProduto",
                table: "Venda",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
