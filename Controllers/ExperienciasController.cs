using Microsoft.AspNetCore.Mvc;
using CurriculoAPI.Models;
using CurriculoAPI.Data;
using CurriculoAPI.Dtos;

namespace CurriculoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExperienciasController : ControllerBase
{
    private readonly AppDbContext _context;

    public ExperienciasController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetExperiencias()
    {
        return Ok(_context.ExperienciasProfissionais.OrderByDescending(e => e.DataInicio).ToList());
    }
    // [HttpGet("{id}")]
    // public IActionResult GetExperienciaById(int id)
    // {
    //     var experiencia = _context.ExperienciasProfissionais.ToList().FirstOrDefault(e => e.Id == id);
    //     if (experiencia == null) { return NotFound(); }
    //     return Ok(experiencia);
    // }
    // [HttpPost]
    // public IActionResult AddExperiencia([FromBody] CreateExperienciaDto dto)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         return BadRequest(ModelState);
    //     }

    //     var experiencia = new ExperienciaProfissional
    //     {
    //         Empresa = dto.Empresa,
    //         Cargo = dto.Cargo,
    //         DataInicio = dto.DataInicio,
    //         DataFim = dto.DataFim,
    //         Descricao = dto.Descricao,
    //         CargoEn = dto.CargoEn,
    //         DescricaoEn = dto.DescricaoEn,
    //         CargoEs = dto.CargoEs,
    //         DescricaoEs = dto.DescricaoEs
    //     };

    //     _context.ExperienciasProfissionais.Add(experiencia);
    //     _context.SaveChanges();

    //     return CreatedAtAction(nameof(GetExperienciaById), new { id = experiencia.Id }, experiencia);
    // }

    // [HttpPut("{id}")]
    // public IActionResult UpdateExperiencia(int id, [FromBody] CreateExperienciaDto dto)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         return BadRequest(ModelState);
    //     }

    //     var experiencia = _context.ExperienciasProfissionais.FirstOrDefault(e => e.Id == id);
    //     if (experiencia == null)
    //     {
    //         return NotFound();
    //     }

    //     experiencia.Empresa = dto.Empresa;
    //     experiencia.Cargo = dto.Cargo;
    //     experiencia.DataInicio = dto.DataInicio;
    //     experiencia.DataFim = dto.DataFim;
    //     experiencia.Descricao = dto.Descricao;
    //     experiencia.CargoEn = dto.CargoEn;
    //     experiencia.DescricaoEn = dto.DescricaoEn;
    //     experiencia.CargoEs = dto.CargoEs;
    //     experiencia.DescricaoEs = dto.DescricaoEs;

    //     _context.SaveChanges();

    //     return Ok(experiencia);
    // }
}
