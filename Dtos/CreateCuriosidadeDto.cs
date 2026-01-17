using System.ComponentModel.DataAnnotations;

namespace CurriculoAPI.Dtos;

public class CreateCuriosidadeDto
{
    [Required(ErrorMessage = "A descrição da curiosidade é obrigatória.")]
    [StringLength(500, ErrorMessage = "A descrição não pode exceder 500 caracteres.")]
    public string Descricao { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "A descrição em inglês não pode exceder 500 caracteres.")]
    public string DescricaoEn { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "A descrição em espanhol não pode exceder 500 caracteres.")]
    public string DescricaoEs { get; set; } = string.Empty;
}
