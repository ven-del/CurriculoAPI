using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurriculoAPI.Data;
using CurriculoAPI.Models;
using CurriculoAPI.Dtos;

namespace CurriculoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SoftskillsController : ControllerBase
{
    private readonly AppDbContext _context;
    public SoftskillsController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Softskill>>> Get()
    {
        var softskills = await _context.Softskills.AsNoTracking().ToListAsync();
        return Ok(softskills);
    }
    [HttpPost]
    public async Task<ActionResult<Softskill>> Post(CreateSoftskillDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var softskill = new Softskill
        {
            NomeSoftskill = dto.NomeSoftskill,
            NomeSoftskillEn = dto.NomeSoftskillEn,
            NomeSoftskillEs = dto.NomeSoftskillEs,
            Nivel = dto.Nivel
        };

        _context.Softskills.Add(softskill);
        await _context.SaveChangesAsync();
        
        return Ok(softskill);
    }
}
