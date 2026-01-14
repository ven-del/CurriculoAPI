namespace CurriculoAPI.Models;

public class Curiosidade
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string DescricaoEn { get; set; } = string.Empty;
    public string DescricaoEs { get; set; } = string.Empty;
}