using System.ComponentModel.DataAnnotations;

namespace CurriculoAPI.Dtos;

public class CreateExperienciaDto
{
    [Required(ErrorMessage = "O nome da empresa é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome da empresa não pode exceder 100 caracteres.")]
    public string Empresa { get; set; } = string.Empty;

    [Required]
    public string Cargo { get; set; } = string.Empty;

    [Required]
    public DateOnly DataInicio { get; set; }

    public DateOnly? DataFim { get; set; }

    [StringLength(500)]
    public string Descricao { get; set; } = string.Empty;

    [StringLength(100)]
    public string CargoEn { get; set; } = string.Empty;

    [StringLength(500)]
    public string DescricaoEn { get; set; } = string.Empty;

    [StringLength(100)]
    public string CargoEs { get; set; } = string.Empty;

    [StringLength(500)]
    public string DescricaoEs { get; set; } = string.Empty;
}
