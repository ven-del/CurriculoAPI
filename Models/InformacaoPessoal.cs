namespace CurriculoAPI.Models;

public class InformacaoPessoal
{
    public int Id { get; set; }
    public string NomeCompleto { get; set; } = string.Empty;
    public string Profissao { get; set; } = string.Empty;
    public string ProfissaoEn { get; set; } = string.Empty;
    public string ProfissaoEs { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string LinkLinkedin { get; set; } = string.Empty;
    public string LinkGitHub { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Localizacao { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public string DescricaoEn { get; set; } = string.Empty;
    public string DescricaoEs { get; set; } = string.Empty;

}