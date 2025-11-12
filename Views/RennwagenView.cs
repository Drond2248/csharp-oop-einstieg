using System;
using CodeTestArea.Models;

namespace CodeTestArea.Views
{
    public static class RennwagenView
    {
        public static void Render(Rennwagen raser)
        {
            Console.WriteLine(" Rennwagen ");
            Console.WriteLine($"Name:     {raser.Name}");
            Console.WriteLine($"Farbe:    {raser.Farbe}");
            Console.WriteLine($"Leistung: {raser.Kw} kW");
            Console.WriteLine($"Hubraum:  {raser.Hubraum}");
            Console.WriteLine($"Team:     {raser.RennTeam}");
            Console.WriteLine();
        }
    }
}
