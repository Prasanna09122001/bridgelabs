using System;
namespace FindMaximum
{
    class program
    {
        static void Main()
        {
            Operation operation = new Operation();
            operation.FindMaxInteger(1, 2, 3);
            operation.FindMaxFloat(1.2f, 1.6f, 1.1f);
            operation.FindMaxString("a", "b", "c"); 
        }
    }
}