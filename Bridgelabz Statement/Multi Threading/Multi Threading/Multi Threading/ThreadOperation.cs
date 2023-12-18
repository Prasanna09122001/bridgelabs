using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threading
{
    public class ThreadOperation
    {
        Operation operation = new Operation();
        public void WithoutUsingThread(List<person> list)
        {
            DateTime start = DateTime.Now;
            foreach (var data in list)
            {
                operation.Addemployeee(data);
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Duration Without Thread" + (end - start));
        }
        public void WithUsingthread(List<person> list)
        {
            DateTime start = DateTime.Now;
            foreach (var data in list)
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Being Added" + data.name);
                    operation.Addemployeee(data);
                    Console.WriteLine("Added" + data.name);
                });
                thread.Start();
                thread.Wait();
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Duration with Thread " + (end - start));
        }
    }
}
