using System;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string[] directories = path.Split('\\');
            string file = directories[directories.Length - 1];
            string fileName = file.Split('.')[0];
            string fileExtension = file.Split('.')[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
