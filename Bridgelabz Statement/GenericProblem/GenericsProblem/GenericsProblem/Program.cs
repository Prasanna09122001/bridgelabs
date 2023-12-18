using System;
namespace GenericsProblem
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Generics Problem");
            Operation operation = new Operation();
            operation.FindMaxInteger(7, 8, 3);
        }
    }
}