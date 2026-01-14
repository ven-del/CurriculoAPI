using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoNovasTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curiosidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    DescricaoEn = table.Column<string>(type: "TEXT", nullable: false),
                    DescricaoEs = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curiosidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hardskills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeHardskill = table.Column<string>(type: "TEXT", nullable: false),
                    Nivel = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardskills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformacoesPessoais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeCompleto = table.Column<string>(type: "TEXT", nullable: false),
                    Profissao = table.Column<string>(type: "TEXT", nullable: false),
                    ProfissaoEn = table.Column<string>(type: "TEXT", nullable: false),
                    ProfissaoEs = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    linkLinkedin = table.Column<string>(type: "TEXT", nullable: false),
                    linkGitHub = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", nullable: false),
                    Localizacao = table.Column<string>(type: "TEXT", nullable: false),
                    FotoPerfil = table.Column<byte[]>(type: "BLOB", nullable: true),
                    FotoAvatar = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacoesPessoais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Softskills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeSoftskill = table.Column<string>(type: "TEXT", nullable: false),
                    NomeSoftskillEn = table.Column<string>(type: "TEXT", nullable: false),
                    NomeSoftskillEs = table.Column<string>(type: "TEXT", nullable: false),
                    Nivel = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softskills", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curiosidades");

            migrationBuilder.DropTable(
                name: "Hardskills");

            migrationBuilder.DropTable(
                name: "InformacoesPessoais");

            migrationBuilder.DropTable(
                name: "Softskills");
        }
    }
}
