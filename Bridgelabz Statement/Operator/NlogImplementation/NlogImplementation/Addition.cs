using System;

namespace NlogImplementation
{
    internal class Addition
    {
        NlogOperation nlog = new NlogOperation();
        public void add(int x,int y)
        {
            nlog.LogDebug("Add() method in the addition class");
            if(x==0 || y==0)
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
