namespace CurriculoAPI.Models;

public class Educacao
{
    public int Id { get; set; }
    public string Curso { get; set; } = string.Empty;
    public string CursoEn { get; set; } = string.Empty;
    public string CursoEs { get; set; } = string.Empty;
    public string Instituicao { get; set; } = string.Empty;
    public DateOnly DataInicio { get; set; }
    public DateOnly? DataFim { get; set; }
}
