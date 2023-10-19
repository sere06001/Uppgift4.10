using System;
using System.Text;

namespace Uppgift4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int antalX = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp?");
            int antalO = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O mönster per rad?");
            int antalOMönster = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int antalRader = int.Parse(Console.ReadLine());

            for (int i = 0; i < antalRader; i++)
            {
                string utskrivnaX = new string('X', antalX);
                string utskrivnaO = new string('O', antalO);
                string utskrivet = utskrivnaX + "-" + utskrivnaO + "-";
                string utskrivnaOMönster = string.Concat(Enumerable.Repeat(utskrivet, antalOMönster));
                Console.WriteLine($"{utskrivnaOMönster}{utskrivnaX}");
            }
            Console.ReadKey();
        }
    }
}