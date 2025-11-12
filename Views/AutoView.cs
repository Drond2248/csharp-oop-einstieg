using System;
using CodeTestArea.Models;

namespace CodeTestArea.Views
{
    public static class AutoView
    {
        public static void Render(Auto m)
        {
            Console.WriteLine($"Auto: {m.Name} ({m.Farbe})");
            Console.WriteLine($"Leistung:  {m.Kw} kW");
            Console.WriteLine($"Hubraum:   {m.Hubraum}");
            Console.WriteLine($"Türen:     {m.Tueren}");
            Console.WriteLine($"Sitze:     {m.Sitzplaetze}");
            Console.WriteLine();
        }
    }
}
