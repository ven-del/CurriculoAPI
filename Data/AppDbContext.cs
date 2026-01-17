using Microsoft.EntityFrameworkCore;
using CurriculoAPI.Models;

namespace CurriculoAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ExperienciaProfissional> ExperienciasProfissionais { get; set; }
    public DbSet<InformacaoPessoal> InformacoesPessoais { get; set; }
    public DbSet<Hardskill> Hardskills { get; set; }
    public DbSet<Softskill> Softskills { get; set; }
    public DbSet<Curiosidade> Curiosidades { get; set; }
}