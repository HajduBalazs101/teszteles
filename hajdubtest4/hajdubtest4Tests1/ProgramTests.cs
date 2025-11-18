using Microsoft.VisualStudio.TestTools.UnitTesting;
using hajdubtest4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdubtest4.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AtlagTest()
        {
            int[] tomb = { 1, 2, 3, 4, 5 };
            double vart = 3.0;
            double kapott = Program.Atlag(tomb);
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod()]
        public void NegativDbTest()
        {
            int[] tomb = { -1, 2, -3, 4, 5 };
            int vart = 2;
            int kapott = Program.NegativDb(tomb);
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod()]
        public void VanNegyzetSzamTest()
        {
            int[] tomb = { -1, 2, 4, 5, 9 };
            bool vart = true;
            bool kapott = Program.VanNegyzetSzam(tomb);
            Assert.AreEqual(vart, kapott);

        }
        [TestMethod()]
        public void ParosAtlagTest()
        {
            int[] tomb = { 1, 2, 3, 4, 5 };
            double vart = 3.0;
            double kapott = Program.ParosAtlag(tomb);
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod()]
        public void MaxIndexTest()
        {
            int[] tomb = { 1, 3, 2, 5, 4 };
            int vart = 3;
            int kapott = Program.MaxIndex(tomb);
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod()]
        public void IsPrimeTest()
        {
            int szam = 13;
            bool vart = true;
            bool kapott = Program.IsPrime(szam);
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod()]
        public void PrimesTest()
        {
            int[] tomb = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var vart = new List<int> { 2, 3, 5, 7 };
            var kapott = Program.Primes(tomb);
            CollectionAssert.AreEqual(vart, kapott);
        }
        [TestMethod()]
        public void OsszegTest()
        {
            int[] tomb = { 1, 2, 3, 4, 5 };
            int vart = 15;
            int kapott = Program.Osszeg(tomb);
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod()]
        public void MinNagyobbMintTest()
        {
            int[] tomb = { 5, 15, 10, 20, 25 };
            int vart = 15;
            int kapott = Program.MinNagyobbMint(tomb, 10);
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod()]
        public void HettelOszthatoTest()
        {
            int[] tomb = { 7, 14, 15, 21, 22 };
            var vart = new List<int> { 7, 14, 21 };
            var kapott = Program.HettelOszthato(tomb);
            CollectionAssert.AreEqual(vart, kapott);
        }
        [TestMethod()]
        public void RendezettTest()
        {
            int[] tomb = { 5, 3, 8, 1, 4 };
            var vart = new List<int> { 1, 3, 4, 5, 8 };
            var kapott = Program.Rendezett(tomb);
            CollectionAssert.AreEqual(vart, kapott);
        }
    }
    }