using System;
using System.Collections.Generic;
namespace GenericsDemo

{
    class program
    {
        static void Main(string[] args)
        {
            int[] intarr = { 1, 2, 3, 4, 5, 6 };
            double[] doublearr = { 89, 89, 78, 789 };
            char[] chararr = { 'a', 'b', 'c' };
 
            genericsdemo demo = new genericsdemo();
            demo.Print<int>(intarr);
            demo.Print<double>(doublearr);
            demo.Print<char>(chararr);
        }
    }
}