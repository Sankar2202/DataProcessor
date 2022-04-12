using System;
using System.IO;
namespace DataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            FileRead fr = new FileRead();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string file = Path.Combine(currentDirectory, @"..\..\..\TextFile1.txt");
            string filePath = Path.GetFullPath(file);
            Console.WriteLine(fr.FileReading(filePath, "binary"));
            Console.WriteLine(fr.FileReading(filePath, "text"));
            Console.WriteLine(fr.FileReading(filePath, "textReverse"));
        }
    }
}
