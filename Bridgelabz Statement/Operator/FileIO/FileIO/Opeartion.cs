using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class Opeartion
    {
        public static void Filexists(string Filepath)
        {
            if (File.Exists(Filepath))
            {
                Console.WriteLine("File Exists");
            }
        }
        public static void ReadAllTextLines(string filepath)
        {
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);
                foreach (var data in lines)
                {
                    Console.WriteLine(data);
                }
            }
            else
            {
                Console.WriteLine("File Doesnt Exists");
            }
        }
        public static void ReadAllText(string filepath)
        {
            if (File.Exists(filepath))
            {
                string lines = File.ReadAllText(filepath);
                Console.WriteLine(lines);
            }
            else
            {
                Console.WriteLine("File Doesnt Exists");
            }
        }
        public static void CreateFile(string filepath)
        {
            File.Create(filepath);
        }
        public static void CopyFilePath(string existing,string copyFilepath)

        {
            File.Copy(existing, copyFilepath);
        public static void ReadFromStreamWriter(string filepath)
        {
            using (StreamWriter stream = File.AppendText(filepath))
            {
                stream.WriteLine("Hello World .Net is Awesome");
                stream.Close();
                ReadAllText(filepath);
            }
        }
    }
}