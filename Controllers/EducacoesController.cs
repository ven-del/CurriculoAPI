using Microsoft.AspNetCore.Mvc;
using CurriculoAPI.Models;
using CurriculoAPI.Data;

namespace CurriculoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EducacoesController : ControllerBase
{
    private readonly AppDbContext _context;

    public EducacoesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetEducacoes()
    {
        return Ok(_context.Educacoes.OrderByDescending(e => e.DataInicio).ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetEducacaoById(int id)
    {
        var educacao = _context.Educacoes.FirstOrDefault(e => e.Id == id);
        if (educacao == null) { return NotFound(); }
        return Ok(educacao);
    }
}
