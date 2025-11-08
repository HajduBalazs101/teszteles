using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdub_test2
{
    public class Bankszamla
    {
        public string Tulajdonos { get; private set; }
        public decimal Egyenleg { get; private set; }

        public Bankszamla(string tulajdonos, decimal kezdoEgyenleg = 0)
        {
            if (string.IsNullOrWhiteSpace(tulajdonos))
                throw new ArgumentException("A tulajdonos neve nem lehet üres.");

            if (kezdoEgyenleg < 0)
                throw new ArgumentException("A kezdő egyenleg nem lehet negatív.");

            Tulajdonos = tulajdonos;
            Egyenleg = kezdoEgyenleg;
        }

        public void Befizet(decimal osszeg)
        {
            if (osszeg <= 0)
                throw new ArgumentException("A befizetett összegnek pozitívnak kell lennie.");
            Egyenleg += osszeg;
        }

        public void Kivesz(decimal osszeg)
        {
            if (osszeg <= 0)
                throw new ArgumentException("A kivett összegnek pozitívnak kell lennie.");

            if (osszeg > Egyenleg)
                throw new InvalidOperationException("Nincs elegendő fedezet a számlán.");

            Egyenleg -= osszeg;
        }

        public void Atutal(Bankszamla celSzamla, decimal osszeg)
        {
            if (celSzamla == null)
                throw new ArgumentNullException(nameof(celSzamla), "A cél számla nem lehet null.");

            Kivesz(osszeg);
            celSzamla.Befizet(osszeg);
        }
        public static void Main()
        {
            var szamla1 = new Bankszamla("Kiss Péter", 1000);
            var szamla2 = new Bankszamla("Nagy Anna", 500);

            szamla1.Atutal(szamla2, 200);

            Console.WriteLine($"{szamla1.Tulajdonos} egyenlege: {szamla1.Egyenleg}");
            Console.WriteLine($"{szamla2.Tulajdonos} egyenlege: {szamla2.Egyenleg}");
        }
    }
}
