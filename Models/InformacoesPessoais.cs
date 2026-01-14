namespace CurriculoAPI.Models;

public class InformacoesPessoais
{
    public int Id { get; set; }
    public string NomeCompleto { get; set; } = string.Empty;
    public string Profissao { get; set; } = string.Empty;
    public string Profissao_En { get; set; } = string.Empty;
    public string Profissao_Es { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string linkLinkedin { get; set; } = string.Empty;
    public string linkGitHub { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Localizacao { get; set; } = string.Empty;
    public byte[]? FotoPerfil { get; set; } 
    public byte[]? FotoAvatar { get; set; }

}