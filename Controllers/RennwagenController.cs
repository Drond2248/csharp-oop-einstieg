using CodeTestArea.Models;
using CodeTestArea.Views;

namespace CodeTestArea.Controllers
{
    public static class RennwagenController
    {
        public static Rennwagen Erstellen(string name, string farbe, int kw, int hubraum, string team)
        {
            return new Rennwagen(name, farbe, kw, hubraum, team);
        }

        public static void Anzeigen(Rennwagen model)
        {
            RennwagenView.Render(model);
        }
    }
}
