namespace CodeTestArea.Models;

public class Rennwagen : Fahrzeug
{
    public string RennTeam { get; }
    public Rennwagen(string name, string farbe, int kw, int hubraum, string rennTeam)
        : base(name, farbe, kw, hubraum)
    {
        RennTeam = rennTeam;
    }
}
