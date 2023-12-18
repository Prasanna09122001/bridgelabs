using System;
namespace ConsoleApp6
{
    class program
    {
        static string filepath = @"D:\Bridgelabz Statement\Operator\ConsoleApp6\ConsoleApp6\Exceptionfile.txt";
        static void Main()
        {
            int[] array = new int[2];
            try
            {
                for(int i=0;i<2;i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                for(int i=0;i<2;i++)
                {
                    Console.WriteLine(array[i] / array[i+1]);
                }
            }
            catch(Exception ex)
            {
                using (StreamWriter stream = File.AppendText(filepath))
                {
                    stream.WriteLine(ex.Message);
                }
                Console.WriteLine(ex.GetType());
            }
        }
    }
}