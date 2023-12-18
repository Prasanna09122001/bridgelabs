using System;

namespace FileIO
{
    class Program
    {
        static void Main()
        {
            string filepath = @"D:\Bridgelabz Statement\Operator\FileIO\FileIO\Sample.txt";
            string Create = @"D:\Bridgelabz Statement\Operator\FileIO\FileIO\Sample1.txt";
            string copy = @"D:\Bridgelabz Statement\Operator\FileIO\FileIO\Samplecopy.txt";
            /*  Opeartion.Filexists(filepath);
              Opeartion.ReadAllTextLines(filepath);
              Opeartion.ReadAllText(filepath);
              Opeartion.CreateFile(Create);
              Opeartion.CopyFilePath(filepath, copy);
              Opeartion.deleteFilepath(copy); 
              Opeartion.ReadFromStreamReader(filepath);
              Opeartion.ReadFromStreamWriter(filepath);*/
           // SerializationandDeserialization.BinarySerialization();
            SerializationandDeserialization.Deserialization();
        }
    }
}