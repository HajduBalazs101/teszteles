using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajdub_test1
{
        public class Szamologep
        {
            public static int Osszead(int a, int b)
            {
                return a + b;
            }

            public static int Kivon(int a, int b)
            {
                return a - b;
            }

            public static int Szoroz(int a, int b)
            {
                return a * b;
            }

            public static int Oszt(int a, int b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Nullával nem lehet osztani!");
                return a / b;
            }
            static void Main(string[] args)
        {
        }
    }
}
