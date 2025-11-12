namespace CodeTestArea.Models;

public class Auto : Fahrzeug
{
    public int Tueren { get; }
    public int Sitzplaetze { get; }

    public Auto(string name, string farbe, int kw, int hubraum, int tueren, int sitzplaetze)
        : base(name, farbe, kw, hubraum)
    {
        Tueren = tueren;
        Sitzplaetze = sitzplaetze;
    }
}
