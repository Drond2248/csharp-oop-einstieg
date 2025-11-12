using CodeTestArea.Models;
using CodeTestArea.Views;

namespace CodeTestArea.Controllers
{
    public static class AutoController
    {
        public static Auto Erstellen(string name, string farbe, int kw, int hubraum, int tueren, int sitze)
        {
            var auto = new Auto(name, farbe, kw, hubraum, tueren, sitze);
            return auto;
        }

        public static void Anzeigen(Auto model)
        {
            AutoView.Render(model);
        }
    }
}
