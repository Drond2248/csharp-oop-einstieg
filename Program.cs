using CodeTestArea.Controllers;

namespace CodeTestArea
{
    internal class Program
    {
        static void Main()
        {
            var golf = AutoController.Erstellen(
                name: "Golf",
                farbe: "Rot",
                kw: 85,
                hubraum: 1600,
                tueren: 5,
                sitze: 5);

            AutoController.Anzeigen(golf);

            var rw = RennwagenController.Erstellen(
                name: "Lotus",
                farbe: "Blau",
                kw: 250,
                hubraum: 4000,
                team: "Team Speed");

            RennwagenController.Anzeigen(rw);
        }
    }
}
