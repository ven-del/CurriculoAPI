using System.ComponentModel.DataAnnotations;

namespace CurriculoAPI.Dtos;

public class CreateHardskillDto
{
    [Required(ErrorMessage = "O nome da hardskill é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome da hardskill não pode exceder 100 caracteres.")]
    public string NomeHardskill { get; set; } = string.Empty;

    [Required(ErrorMessage = "O nível é obrigatório.")]
    [Range(1, 10, ErrorMessage = "O nível deve estar entre 1 e 10.")]
    public int Nivel { get; set; }
}
