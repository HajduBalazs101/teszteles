using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdubtest4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[20];

            // Véletlenszámok -15 és 120 között
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-15, 121);
            }

            Console.WriteLine("Tömb elemei: " + string.Join(", ", tomb));
            Console.WriteLine();

            Console.WriteLine("Átlag: " + Atlag(tomb));
            Console.WriteLine("Mínusz számok darabszáma: " + NegativDb(tomb));
            Console.WriteLine("Tartalmaz-e négyzetszámot? " + VanNegyzetSzam(tomb));
            Console.WriteLine("Páros számok átlaga: " + ParosAtlag(tomb));
            Console.WriteLine("Max érték indexe: " + MaxIndex(tomb));
            Console.WriteLine("Csak prímszámok: " + string.Join(", ", Primes(tomb)));
            Console.WriteLine("Összes szám összege: " + Osszeg(tomb));
            Console.WriteLine("Legkisebb 10-nél nagyobb szám: " + MinNagyobbMint(tomb, 10));
            Console.WriteLine("7-tel oszthatók: " + string.Join(", ", HettelOszthato(tomb)));
            Console.WriteLine("Rendezett tömb: " + string.Join(", ", Rendezett(tomb)));
        }

        //---- Függvények (unit-testbarát) ----//

        public static double Atlag(int[] tomb)
        {
            if (tomb.Length == 0) return 0;
            return tomb.Average();
        }

        public static int NegativDb(int[] tomb)
        {
            return tomb.Count(x => x < 0);
        }

        public static bool VanNegyzetSzam(int[] tomb)
        {
            return tomb.Any(x =>
            {
                int gyok = (int)Math.Sqrt(Math.Abs(x));
                return gyok * gyok == x;
            });
        }

        public static double ParosAtlag(int[] tomb)
        {
            var parosak = tomb.Where(x => x % 2 == 0).ToList();
            if (parosak.Count == 0) return 0;
            return parosak.Average();
        }

        public static int MaxIndex(int[] tomb)
        {
            if (tomb.Length == 0) return -1;
            int max = tomb[0];
            int index = 0;

            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                    index = i;
                }
            }
            return index;
        }

        public static int[] Primes(int[] tomb)
        {
            return tomb.Where(IsPrime).ToArray();
        }

        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        public static int Osszeg(int[] tomb)
        {
            return tomb.Sum();
        }

        public static int MinNagyobbMint(int[] tomb, int p)
        {
            var szurt = tomb.Where(x => x > p);
            if (!szurt.Any()) return int.MinValue;
            return szurt.Min();
        }

        public static int[] HettelOszthato(int[] tomb)
        {
            return tomb.Where(x => x % 7 == 0).ToArray();
        }

        public static int[] Rendezett(int[] tomb)
        {
            // NEM módosítja az eredeti tömböt
            int[] uj = (int[])tomb.Clone();
            Array.Sort(uj);
            return uj;
        }
    }
}
