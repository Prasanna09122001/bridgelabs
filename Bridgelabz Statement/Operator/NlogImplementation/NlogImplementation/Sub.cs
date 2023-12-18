using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogImplementation
{
    internal class Sub
    {
        NlogOperation nlog = new NlogOperation();
        public void add(int x, int y)
        {
            nlog.LogDebug("Add() method in the addition class");
            if (x == 0 || y == 0)
            {
                nlog.LogError("Either a or b is 0");
                nlog.LogWarn("Either a or b is 0");
            }
            int c = x + y;
            Console.WriteLine(c);
            nlog.LogInfo("Result is c");
        }
    }
}
