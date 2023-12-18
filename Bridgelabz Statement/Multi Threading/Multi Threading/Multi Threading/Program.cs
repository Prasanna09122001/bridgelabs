using Multi_Threading;
using System;
using System.Net;

namespace Multi_Threading
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome");
            Operation employeeoperation = new Operation();
            List<person> list = new List<person>();
            list.Add(new person() { name = "a", city = "a", address = "a" });
            list.Add(new person() { name = "b", city = "b", address = "b" });
            list.Add(new person() { name = "c", city = "c", address = "c" });
            list.Add(new person() { name = "d", city = "d", address = "d" });
            list.Add(new person() { name = "e", city = "e", address = "e" });
            list.Add(new person() { name = "f", city = "f", address = "f" });
            ThreadOperation thread = new ThreadOperation();
            //thread.WithoutUsingThread(list);
            //thread.WithUsingthread(list);
            TaskParallelLibrary task = new TaskParallelLibrary();
            task.TaskParllelOperation();

        }

    }
}