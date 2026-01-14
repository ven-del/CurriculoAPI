namespace CurriculoAPI.Models;

public class Softskill
{
    public int Id { get; set; }
    public string NomeSoftskill { get; set; } = string.Empty;
    public string NomeSoftskillEn { get; set; } = string.Empty;
    public string NomeSoftskillEs { get; set; } = string.Empty;
    public int Nivel { get; set; }
}