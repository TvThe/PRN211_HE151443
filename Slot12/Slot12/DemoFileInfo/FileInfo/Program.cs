using System;
using System.IO;
using System.Text;
namespace Demo_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"MyFile.txt";
            Console.WriteLine(" *** Demo FileInfo ***\n");
            File.WriteAllText(FileName, "Hello world");
            Console.WriteLine("Read file: ");
            string content = File.ReadAllText(FileName);
            Console.WriteLine(content);
            Console.WriteLine("File info: ");
            FileInfo testFile = new FileInfo(FileName);
            Console.WriteLine($"Name:{testFile.Name}");
            Console.WriteLine($"Create time: {testFile.CreationTime}");
            Console.WriteLine($"Last Wite time: {testFile.LastWriteTime}");
            Console.WriteLine($"Directory Name: {testFile.DirectoryName}");
            Console.ReadLine();
        }
    }
}
