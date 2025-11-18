using Microsoft.VisualStudio.TestTools.UnitTesting;
using hajdubtest5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdubtest5.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SzavakSzamaTest()
        {
            string szoveg = "Ez egy teszt szöveg";
            int eredmeny = Program.SzavakSzama(szoveg);
            Assert.AreEqual(4, eredmeny);
        }
        [TestMethod()]
        public void LeghosszabbSzoTest()
        {
            string szoveg = "Ez egy teszt szöveg";
            string eredmeny = Program.LeghosszabbSzo(szoveg);
            Assert.AreEqual("szöveg", eredmeny);
        }
        [TestMethod()]
        public void TartalmazETest()
        {
            string szoveg = "Ez egy teszt szöveg";
            bool eredmeny = Program.TartalmazE(szoveg, "teszt");
            Assert.IsTrue(eredmeny);

        }
        [TestMethod()]
        public void CsakBetukTest()
        {
            string szoveg = "Ez! egy teszt szöveg 123";
            string eredmeny = Program.CsakBetuk(szoveg);
            Assert.AreEqual("Ezegytesztszöveg", eredmeny);
        }
        [TestMethod()]
        public void NagybetusSzavakTest()
        {
            string szoveg = "Ez egy Teszt Szöveg";
            string[] eredmeny = Program.NagybetusSzavak(szoveg);
            CollectionAssert.AreEqual(new string[] { "Ez", "Teszt", "Szöveg" }, eredmeny);
        }
        [TestMethod()]
        public void RendezettSzavakTest()
        {
            string szoveg = "Ez egy teszt szöveg";
            string[] eredmeny = Program.RendezettSzavak(szoveg);
            var vvart = new string[] { "egy", "Ez", "szöveg", "teszt" };
            CollectionAssert.AreEqual(vvart, eredmeny);
        }
        [TestMethod()]
        public void SzoGyakorisagTest()
        {
            string szoveg = "teszt szöveg teszt";
            var eredmeny = Program.SzoGyakorisag(szoveg);
            var elvart = new Dictionary<string, int>
            {
                { "teszt", 2 },
                {"szöveg", 1 }
                
            };
            CollectionAssert.AreEquivalent(elvart, eredmeny);
        }
        
    }
    }