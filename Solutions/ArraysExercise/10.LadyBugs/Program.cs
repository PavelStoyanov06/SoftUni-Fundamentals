using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] fieldFilled = new int[fieldSize];

            for (int i = 0; i < indexes.Length; i++)
            {
                if(indexes[i] >= 0 && indexes[i] < fieldSize)fieldFilled[indexes[i]] = 1;
            }

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] arrInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int index = int.Parse(arrInput[0]);
                string direction = arrInput[1];
                int moveBy = int.Parse(arrInput[2]);

                if(index >= 0 && index < fieldSize && fieldFilled[index] == 1)
                {
                    fieldFilled[index] = 0;
                    if (direction == "right")
                    {
                        index += moveBy;
                        
                    }
                    else if (direction == "left")
                    {
                        index -= moveBy;
                    }

                    while (index >= 0 && index < fieldSize && fieldFilled[index] == 1)
                    {
                        if (direction == "right") index += moveBy;
                        else if(direction == "left") index -= moveBy;
                    }
                    if (index >= 0 && index < fieldSize) fieldFilled[index] = 1;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", fieldFilled));
        }
    }
}
