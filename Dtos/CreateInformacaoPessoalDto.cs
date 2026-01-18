using System.ComponentModel.DataAnnotations;

namespace CurriculoAPI.Dtos;

public class CreateInformacaoPessoalDto
{
    [Required(ErrorMessage = "O nome completo é obrigatório.")]
    [StringLength(200, ErrorMessage = "O nome completo não pode exceder 200 caracteres.")]
    public string NomeCompleto { get; set; } = string.Empty;

    [Required(ErrorMessage = "A profissão é obrigatória.")]
    [StringLength(100, ErrorMessage = "A profissão não pode exceder 100 caracteres.")]
    public string Profissao { get; set; } = string.Empty;

    [StringLength(100)]
    public string ProfissaoEn { get; set; } = string.Empty;

    [StringLength(100)]
    public string ProfissaoEs { get; set; } = string.Empty;

    [Required(ErrorMessage = "O email é obrigatório.")]
    [EmailAddress(ErrorMessage = "Email inválido.")]
    [StringLength(150)]
    public string Email { get; set; } = string.Empty;

    [Url(ErrorMessage = "URL do LinkedIn inválida.")]
    [StringLength(200)]
    public string LinkLinkedin { get; set; } = string.Empty;

    [Url(ErrorMessage = "URL do GitHub inválida.")]
    [StringLength(200)]
    public string LinkGitHub { get; set; } = string.Empty;

    [Phone(ErrorMessage = "Telefone inválido.")]
    [StringLength(20)]
    public string Telefone { get; set; } = string.Empty;

    [StringLength(150)]
    public string Localizacao { get; set; } = string.Empty;
}
