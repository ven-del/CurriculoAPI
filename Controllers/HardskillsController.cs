using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurriculoAPI.Data;
using CurriculoAPI.Models;
using CurriculoAPI.Dtos;

namespace CurriculoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HardskillsController : ControllerBase
{
    private readonly AppDbContext _context;
    public HardskillsController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hardskill>>> Get()
    {
        var hardskills = await _context.Hardskills.AsNoTracking().ToListAsync();
        return Ok(hardskills);
    }
    // [HttpPost]
    // public async Task<ActionResult<Hardskill>> Post(CreateHardskillDto dto)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         return BadRequest(ModelState);
    //     }

    //     var hardskill = new Hardskill
    //     {
    //         NomeHardskill = dto.NomeHardskill,
    //         Nivel = dto.Nivel
    //     };

    //     _context.Hardskills.Add(hardskill);
    //     await _context.SaveChangesAsync();
        
    //     return Ok(hardskill);
    // }
}