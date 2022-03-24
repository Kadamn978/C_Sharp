using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_InheritanceAndPloymorphism
{
    internal class Calculation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Addition(int a, int b, int c)
        {
            return a + b +c ;
        }
        public double Addition(int a, int b, double c)
        {
            return a + b + c;
        }
    }
}
