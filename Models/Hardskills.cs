namespace CurriculoAPI.Models;

public class Hardskills
{
    public int Id { get; set; }
    public string Hardskill { get; set; } = string.Empty;
    public int Nivel { get; set; } // Nível de proficiência (por exemplo, de 1 a 10)
}