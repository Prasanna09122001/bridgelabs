using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Operation
    {
        public void FindMaxInteger(int a,int b,int c)
        {
            if(a>=b && a>=c)
                Console.WriteLine("A is Maximum");
            if(b>=c && b>=c)
                Console.WriteLine("B is Maximum");
            if(c>=a && c>=b)
                Console.WriteLine("C is Maximum");
        }
        public void FindMaxFloat(float a, float b, float c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("A is Maximum");
            if (b >= c && b >= c)
                Console.WriteLine("B is Maximum");
            if (c >= a && c >= b)
                Console.WriteLine("C is Maximum");
        }
        public void FindMaxString(string a, string b, string c)
        {
            if (a.CompareTo(b)>=0 && a.CompareTo (c)>=0)
                Console.WriteLine("A is Maximum");
            if (b.CompareTo(a) >= 0 && b.CompareTo(c) >= 0)
                Console.WriteLine("B is Maximum");
            if (c.CompareTo(a) >= 0 && c.CompareTo(b) >= 0)
                Console.WriteLine("C is Maximum");
        }
    }
}
