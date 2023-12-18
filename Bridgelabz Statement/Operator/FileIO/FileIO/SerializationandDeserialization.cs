using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class SerializationandDeserialization
    {
        public static void BinarySerialization()
        {
            Demo demo = new Demo();
            FileStream file = new FileStream(@"D:\Bridgelabz Statement\Operator\FileIO\FileIO\Sample1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, demo);
        }
        public static void Deserialization()
        {
            FileStream file = new FileStream(@"D:\Bridgelabz Statement\Operator\FileIO\FileIO\Sample.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo demo = (Demo)formatter.Deserialize(file);
            Console.WriteLine(demo.ApplicationId+","+demo.Applicationname);
        }
    }

    [Serializable]
    public class Demo
    {
        public int ApplicationId { get; set; } = 1001;
        public string Applicationname { get; set; } = "Physics";
    }
}
