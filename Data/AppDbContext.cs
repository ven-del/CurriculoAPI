using Microsoft.EntityFrameworkCore;
using CurriculoAPI.Models;

namespace CurriculoAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ExperienciaProfissional> Experiencias { get; set; }
}