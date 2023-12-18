using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Demo
    {
        public void Print(int[] arr)
        {
            foreach(var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        public void Print(double[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        public void Print(char[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
