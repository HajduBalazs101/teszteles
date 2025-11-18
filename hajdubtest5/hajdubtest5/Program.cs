using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdubtest5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string szoveg = "A C# egy nagyon sokoldalú, modern, objektumorientált programozási nyelv.";

            Console.WriteLine("Szöveg: " + szoveg);
            Console.WriteLine("Szavak száma: " + SzavakSzama(szoveg));
            Console.WriteLine("Leghosszabb szó: " + LeghosszabbSzo(szoveg));
            Console.WriteLine("Rendezett szavak: " + string.Join(", ", RendezettSzavak(szoveg)));
            Console.WriteLine("Van-e benne 'nyelv'? " + TartalmazE(szoveg, "nyelv"));
            Console.WriteLine("Mely szavak kezdődnek nagybetűvel? " + string.Join(", ", NagybetusSzavak(szoveg)));
            Console.WriteLine("Csak betűk a szövegből: " + CsakBetuk(szoveg));
            Console.WriteLine("Szógyakoriság: " + string.Join(", ", SzoGyakorisag(szoveg)));
        }

        public static int SzavakSzama(string szoveg)
        {
            return szoveg.Split(new[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string LeghosszabbSzo(string szoveg)
        {
            return szoveg.Split(new[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries)
                         .OrderByDescending(s => s.Length)
                         .FirstOrDefault() ?? "";
        }

        public static string[] RendezettSzavak(string szoveg)
        {
            return szoveg.Split(new[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries)
                         .OrderBy(s => s)
                         .ToArray();
        }

        public static bool TartalmazE(string szoveg, string keresett)
        {
            return szoveg.ToLower().Contains(keresett.ToLower());
        }

        public static string[] NagybetusSzavak(string szoveg)
        {
            return szoveg.Split(new[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries)
                         .Where(s => char.IsUpper(s[0]))
                         .ToArray();
        }

        public static string CsakBetuk(string szoveg)
        {
            return new string(szoveg.Where(char.IsLetter).ToArray());
        }

        public static Dictionary<string, int> SzoGyakorisag(string szoveg)
        {
            return szoveg.ToLower()
                         .Split(new[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries)
                         .GroupBy(s => s)
                         .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
