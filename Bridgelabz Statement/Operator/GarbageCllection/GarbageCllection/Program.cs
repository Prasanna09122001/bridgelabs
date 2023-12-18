using System;
using System.Net.Http.Headers;

namespace GarbageCllection
{
    class program
    {
        static void Main()
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[5000];
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            Console.WriteLine("Mem1 "+mem1);
            Console.WriteLine("Mem2 " + mem2);
            Console.WriteLine("Mem3 " + mem3);
        }
    }
}