using System;
using System.Linq;

namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
