using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder newStr = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                bool end = false;
                newStr.Append(str[i]);
                if (i + 1 < str.Length)
                {
                    while (str[i] == str[i + 1])
                    {
                        if (i + 1 < str.Length - 1)
                        {
                            i++;
                        }
                        else
                        {
                            end = true;
                            break;
                        }
                    }
                }
                if (end)
                {
                    break;
                }
            }

            Console.WriteLine(newStr);
        }
    }
}
