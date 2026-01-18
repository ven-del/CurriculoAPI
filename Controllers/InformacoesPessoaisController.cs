using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurriculoAPI.Data;
using CurriculoAPI.Models;
using CurriculoAPI.Dtos;

namespace CurriculoAPI.Controllers;

[ApiController]
[Route("api/[controller]")] 
public class InformacoesPessoaisController : ControllerBase
{
    private readonly AppDbContext _context;
    public InformacoesPessoaisController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<InformacaoPessoal>> Get()
    {
        var informacao = await _context.InformacoesPessoais.AsNoTracking().FirstOrDefaultAsync();

        if (informacao == null)
        {
            return NotFound("Curriculo não encontrado.");
        }
        return Ok(informacao);
    }
    [HttpPost]
    public async Task<ActionResult<InformacaoPessoal>> Post(CreateInformacaoPessoalDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var informacaoPessoal = new InformacaoPessoal
        {
            NomeCompleto = dto.NomeCompleto,
            Profissao = dto.Profissao,
            ProfissaoEn = dto.ProfissaoEn,
            ProfissaoEs = dto.ProfissaoEs,
            Email = dto.Email,
            LinkLinkedin = dto.LinkLinkedin,
            LinkGitHub = dto.LinkGitHub,
            Telefone = dto.Telefone,
            Localizacao = dto.Localizacao
        };

        _context.InformacoesPessoais.Add(informacaoPessoal);
        await _context.SaveChangesAsync();
        
        return Ok(informacaoPessoal);
    }
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateInformacaoPessoalDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var informacao = await _context.InformacoesPessoais.FirstOrDefaultAsync();
        if (informacao == null)
        {
            return NotFound("Informações pessoais não encontradas.");
        }

        informacao.NomeCompleto = dto.NomeCompleto;
        informacao.Profissao = dto.Profissao;
        informacao.ProfissaoEn = dto.ProfissaoEn;
        informacao.ProfissaoEs = dto.ProfissaoEs;
        informacao.Email = dto.Email;
        informacao.LinkLinkedin = dto.LinkLinkedin;
        informacao.LinkGitHub = dto.LinkGitHub;
        informacao.Telefone = dto.Telefone;
        informacao.Localizacao = dto.Localizacao;

        await _context.SaveChangesAsync();

        return Ok(informacao);
    }
}