using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurriculoAPI.Data;
using CurriculoAPI.Models;
using CurriculoAPI.Dtos;

namespace CurriculoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CuriosidadesController : ControllerBase
{
    private readonly AppDbContext _context;
    public CuriosidadesController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Curiosidade>>> Get()
    {
        var curiosidades = await _context.Curiosidades.AsNoTracking().ToListAsync();
        return Ok(curiosidades);
    }
    [HttpPost]
    public async Task<ActionResult<Curiosidade>> Post(CreateCuriosidadeDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var curiosidade = new Curiosidade
        {
            Descricao = dto.Descricao,
            DescricaoEn = dto.DescricaoEn,
            DescricaoEs = dto.DescricaoEs
        };

        _context.Curiosidades.Add(curiosidade);
        await _context.SaveChangesAsync();
        
        return Ok(curiosidade);
    }
}
