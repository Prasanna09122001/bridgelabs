using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericsDemo
{
    public class genericsdemo
    {
        public void Print<T>(T[] arr)
        {
            foreach(var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
