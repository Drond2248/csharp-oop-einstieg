namespace CodeTestArea.Models;

public class Fahrzeug
{
    public string Name { get; }
    public string Farbe { get; }
    public int Kw { get; }
    public int Hubraum { get; }
    public Fahrzeug(string name, string farbe, int kw, int hubraum)
    {
        Name = name; Farbe = farbe; Kw = kw; Hubraum = hubraum;
    }
}
