using Microsoft.VisualStudio.TestTools.UnitTesting;
using hajdub_test2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdub_test2.Tests
{
    [TestClass()]
    public class BankszamlaTests
    {
        [TestMethod()]
        public void befizetes()
        {
            var szamla = new Bankszamla("Teszt", 1000);
            int befizetendoOsszeg = 500;
            szamla.Befizet(befizetendoOsszeg);
            Assert.AreEqual(1500, szamla.Egyenleg);
        }

        [TestMethod()]
        public void kivetel()
        {
            var szamla = new Bankszamla("Teszt", 1000);
            int kivenniOsszeg = 400;
            szamla.Kivesz(kivenniOsszeg);
            Assert.AreEqual(600, szamla.Egyenleg);
        }
        [TestMethod()]
        public void utalas()
        {
            var szamla1 = new Bankszamla("Teszt1", 1000);
            var szamla2 = new Bankszamla("Teszt2", 500);
            int atutalandoOsszeg = 300;
            szamla1.Atutal(szamla2, atutalandoOsszeg);
            Assert.AreEqual(700, szamla1.Egyenleg);
            Assert.AreEqual(800, szamla2.Egyenleg);
        }
        
    }
}