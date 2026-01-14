namespace CurriculoAPI.Models;

public class Hardskill
{
    public int Id { get; set; }
    public string NomeHardskill { get; set; } = string.Empty;
    public int Nivel { get; set; } // Nível de proficiência (por exemplo, de 1 a 10)
}