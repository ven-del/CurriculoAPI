using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaTraducoesCargos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CargoEn",
                table: "Experiencias",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CargoEs",
                table: "Experiencias",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoEn",
                table: "Experiencias",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoEs",
                table: "Experiencias",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CargoEn",
                table: "Experiencias");

            migrationBuilder.DropColumn(
                name: "CargoEs",
                table: "Experiencias");

            migrationBuilder.DropColumn(
                name: "DescricaoEn",
                table: "Experiencias");

            migrationBuilder.DropColumn(
                name: "DescricaoEs",
                table: "Experiencias");
        }
    }
}
