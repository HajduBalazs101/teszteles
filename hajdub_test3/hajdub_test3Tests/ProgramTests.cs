using Microsoft.VisualStudio.TestTools.UnitTesting;
using hajdub_test3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdub_test3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void PozitivNegativTest()
        {   
            Assert.AreEqual("Negatív szám.", Program.PozitivNegativ(-3)); 
        }
        [TestMethod()]
        public void ParosParatlanTest()
        {
            Assert.AreEqual("Páros szám.", Program.ParosParatlan(4));
        }
        [TestMethod()]
        public void OszthatoHarommalTest()
        {
            Assert.AreEqual("Nem osztható 3-mal.", Program.OszthatoHarommal(10));
        }
        [TestMethod()]
        public void NegyzetTest()
        {

            Assert.AreEqual(9, Program.Negyzet(-3));
            Assert.AreEqual(0, Program.Negyzet(0));
        }
    }
    
}



