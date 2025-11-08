using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdub_test3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Számvizsgáló program függvényekkel\n");

            Console.Write("Adj meg egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            // Függvények meghívása
            Console.WriteLine($"\nA(z) {szam} tulajdonságai:");
            Console.WriteLine(PozitivNegativ(szam));
            Console.WriteLine(ParosParatlan(szam));
            Console.WriteLine(OszthatoHarommal(szam));
            Console.WriteLine($"Négyzete: {Negyzet(szam)}");
        }

        // --- Függvények ---

        // Megállapítja, hogy pozitív, negatív vagy nulla
        public static string PozitivNegativ(int n)
        {
            if (n > 0)
                return "Pozitív szám.";
            else if (n < 0)
                return "Negatív szám.";
            else
                return "A szám nulla.";
        }

        // Megállapítja, hogy páros vagy páratlan
        public static string ParosParatlan(int n)
        { 
            if (n % 2 == 0)
                return "Páros szám.";
            else
                return "Páratlan szám.";
        }

        // Megnézi, hogy osztható-e 3-mal
        public static string OszthatoHarommal(int n)
        {
            if (n % 3 == 0)
                return "Osztható 3-mal.";
            else
                return "Nem osztható 3-mal.";
        }

        // Kiszámítja a szám négyzetét
        public static int Negyzet(int n)
        {
            return n * n;
        }
    }
}
