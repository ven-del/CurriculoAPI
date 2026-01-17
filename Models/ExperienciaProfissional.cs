namespace CurriculoAPI.Models;

public class ExperienciaProfissional
{
    public int Id { get; set; }
    public string Empresa { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;
    public DateOnly DataInicio { get; set; }
    public DateOnly? DataFim { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string CargoEn { get; set; } = string.Empty;
    public string DescricaoEn { get; set; } = string.Empty;
    public string CargoEs { get; set; } = string.Empty;
    public string DescricaoEs { get; set; } = string.Empty;
}