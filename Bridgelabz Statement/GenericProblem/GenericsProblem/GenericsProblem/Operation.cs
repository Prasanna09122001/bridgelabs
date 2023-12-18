using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    internal class Operation
    {
        public void FindMaxInteger(int a, int b, int c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("A is Maximum");
            if (b >= c && b >= c)
                Console.WriteLine("B is Maximum");
            if (c >= a && c >= b)
                Console.WriteLine("C is Maximum");
        }
    }
}
