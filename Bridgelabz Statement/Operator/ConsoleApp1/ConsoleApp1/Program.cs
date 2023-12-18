using NlogImplementation;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class program
    {
        static int add(int n)
        {
            NlogOperation nLog = new NlogOperation();
            nLog.LogInfo("Calling the object of Addition Class");
            Console.WriteLine("Write the Total Number");
            int[] a = new int[n];
            int b = 0,c=0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Even Number are");
            foreach (int i in a)
            {
                if (i == 1)
                    b++;
            }
            return b;
        }
        static void Main()
        {
            Console.WriteLine(add(4));
        }
    }
}