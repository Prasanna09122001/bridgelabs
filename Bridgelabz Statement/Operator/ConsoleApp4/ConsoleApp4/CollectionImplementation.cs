using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CollectionImplementation
    {
        public void ListDemo()
        {
            Console.WriteLine("Proceeding with the list");
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            foreach(var Data in list)
            {
                Console.WriteLine(Data);
            }
            list.Remove("c");
            foreach (var Data in list)
            {
                Console.WriteLine(Data);
            }
        }
        public void StackDemo()
        {
            Console.WriteLine("Proceeding with the Stack");
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            foreach (var Data in stack)
            {
                Console.WriteLine(Data);
            }
            stack.Pop();
            foreach (var Data in stack)
            {
                Console.WriteLine(Data);
            }

        }
        public void QueueDemo()
        {
            Console.WriteLine("Proceeding with the Queue");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            foreach (var Data in queue)
            {
                Console.WriteLine(Data);
            }
            queue.Dequeue();
            foreach (var Data in queue)
            {
                Console.WriteLine(Data);
            }

            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            Console.WriteLine("Using Enumerator");
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void DictionaryDemo()
        {
            Console.WriteLine("Proceeding with the Dictionary");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "a");
            dict.Add(2, "b");
            dict.Add(3, "c");
            foreach(var data in dict)
            {
                Console.WriteLine(data.Key);
                Console.WriteLine(data.Value);
            }
            Dictionary<int, List<string>> list = new Dictionary<int, List<string>>();
            List<string> listdata = new List<string>();
            listdata.Add("a");
            listdata.Add("b");
            listdata.Add("c");
            list.Add(4, listdata);
            foreach(var item in list)
            {
                Console.WriteLine(item.Key);
                foreach(var data in item.Value)
                {
                    Console.WriteLine(data);
                }
            }
        }
        public void SetDemo()
        {
            Console.WriteLine("Proceeding with Set");
            var set = new HashSet<string>();
            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("a");
            foreach(var data in set)
            {
                Console.WriteLine(data);
            }
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
