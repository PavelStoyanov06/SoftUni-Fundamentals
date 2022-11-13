using System;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string sequence = Console.ReadLine();
            while(sequence.Contains(remove))
            {
                sequence = sequence.Remove(sequence.IndexOf(remove), remove.Length);
            }
            Console.WriteLine(sequence);
        }
    }
}
