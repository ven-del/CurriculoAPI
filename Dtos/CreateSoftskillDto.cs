using System.ComponentModel.DataAnnotations;

namespace CurriculoAPI.Dtos;

public class CreateSoftskillDto
{
    [Required(ErrorMessage = "O nome da softskill é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome da softskill não pode exceder 100 caracteres.")]
    public string NomeSoftskill { get; set; } = string.Empty;

    [StringLength(100, ErrorMessage = "O nome da softskill em inglês não pode exceder 100 caracteres.")]
    public string NomeSoftskillEn { get; set; } = string.Empty;

    [StringLength(100, ErrorMessage = "O nome da softskill em espanhol não pode exceder 100 caracteres.")]
    public string NomeSoftskillEs { get; set; } = string.Empty;

    [Required(ErrorMessage = "O nível é obrigatório.")]
    [Range(1, 10, ErrorMessage = "O nível deve estar entre 1 e 10.")]
    public int Nivel { get; set; }
}
