using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaDescricaoInformacoesPessoais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiencias",
                table: "Experiencias");

            migrationBuilder.DropColumn(
                name: "FotoAvatar",
                table: "InformacoesPessoais");

            migrationBuilder.DropColumn(
                name: "FotoPerfil",
                table: "InformacoesPessoais");

            migrationBuilder.RenameTable(
                name: "Experiencias",
                newName: "ExperienciasProfissionais");

            migrationBuilder.RenameColumn(
                name: "linkLinkedin",
                table: "InformacoesPessoais",
                newName: "LinkLinkedin");

            migrationBuilder.RenameColumn(
                name: "linkGitHub",
                table: "InformacoesPessoais",
                newName: "LinkGitHub");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "InformacoesPessoais",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoEn",
                table: "InformacoesPessoais",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescricaoEs",
                table: "InformacoesPessoais",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExperienciasProfissionais",
                table: "ExperienciasProfissionais",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ExperienciasProfissionais",
                table: "ExperienciasProfissionais");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "InformacoesPessoais");

            migrationBuilder.DropColumn(
                name: "DescricaoEn",
                table: "InformacoesPessoais");

            migrationBuilder.DropColumn(
                name: "DescricaoEs",
                table: "InformacoesPessoais");

            migrationBuilder.RenameTable(
                name: "ExperienciasProfissionais",
                newName: "Experiencias");

            migrationBuilder.RenameColumn(
                name: "LinkLinkedin",
                table: "InformacoesPessoais",
                newName: "linkLinkedin");

            migrationBuilder.RenameColumn(
                name: "LinkGitHub",
                table: "InformacoesPessoais",
                newName: "linkGitHub");

            migrationBuilder.AddColumn<byte[]>(
                name: "FotoAvatar",
                table: "InformacoesPessoais",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FotoPerfil",
                table: "InformacoesPessoais",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiencias",
                table: "Experiencias",
                column: "Id");
        }
    }
}
