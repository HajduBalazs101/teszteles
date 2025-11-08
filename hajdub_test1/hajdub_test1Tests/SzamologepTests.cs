using Microsoft.VisualStudio.TestTools.UnitTesting;
using hajdub_test1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdub_test1.Tests
{
    [TestClass()]
    public class SzamologepTests
    {
        [TestMethod()]
        public void OsszeadTest()
        {
            int eredmeny = Szamologep.Osszead(5, 3);
            Assert.AreEqual(8, eredmeny);
        }
        [TestMethod()]
        public void KivonTest()
        {
            int eredmeny = Szamologep.Kivon(10, 4);
            Assert.AreEqual(6, eredmeny);
        }
        [TestMethod()]
        public void SzorozTest()
        {
            int eredmeny = Szamologep.Szoroz(6, 7);
            Assert.AreEqual(42, eredmeny);
        }
        [TestMethod()]
        public void OsztTest()
        {
            int eredmeny = Szamologep.Oszt(20, 4);
            Assert.AreEqual(5, eredmeny);
        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Oszt_NullaTest()
        {
            Szamologep.Oszt(10, 0);
        }

    }
}