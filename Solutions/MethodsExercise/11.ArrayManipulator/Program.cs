using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = string.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split().ToArray();

                string cmdType = cmdArgs[0];

                if(cmdType == "exchange")
                {
                    int index = int.Parse(cmdArgs[1].ToString());
                    if(index < 0 || index >= arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    arr = ExchangeArray(arr, index);
                }
                else if(cmdType == "max" || cmdType == "min")
                {
                    string evenOdd = cmdArgs[1];

                    int minMaxIndex = -1;

                    if(cmdType == "min")
                    {
                        minMaxIndex = MinEvenOdd(arr, evenOdd);
                    }
                    else if(cmdType == "max")
                    {
                        minMaxIndex = MaxEvenOdd(arr, evenOdd);
                    }

                    if(minMaxIndex == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }

                    Console.WriteLine(minMaxIndex);
                }
                else if(cmdType == "first" || cmdType == "last")
                {
                    int count = int.Parse(cmdArgs[1].ToString());

                    if(count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    string evenOdd = cmdArgs[2];

                    int[] firstLastOddEven = new int[count];
                    if (cmdType == "first")
                    {
                        firstLastOddEven = FirstElement(count, arr, evenOdd).Where(x => x != -1).ToArray();
                    }
                    else if (cmdType == "last")
                    {
                        firstLastOddEven = LastElement(count, arr, evenOdd).Where(x => x != -1).ToArray();
                    }

                    Console.WriteLine($"[{String.Join(", ", firstLastOddEven)}]");
                }
            }

            Console.WriteLine($"[{String.Join(", ", arr)}]");
        }

        static int[] LastElement(int count, int[] arr, string type)
        {
            int[] newArr = new int[count];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = -1;
            }

            int newArrIndex = newArr.Length - 1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if ((type == "even" && arr[i] % 2 == 0) || (type == "odd" && arr[i] % 2 == 1))
                {
                    newArr[newArrIndex] = arr[i];
                    newArrIndex--;
                    if (newArrIndex < 0) break;
                }
            }

            return newArr;
        }

        static int[] FirstElement(int count, int[] arr, string type)
        {
            int[] newArr = new int[count];

            for(int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = -1;
            }

            int newArrIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((type == "even" && arr[i] % 2 == 0) || (type == "odd" && arr[i] % 2 == 1))
                {
                    newArr[newArrIndex] = arr[i];
                    newArrIndex++;
                    if (newArrIndex >= newArr.Length) break;
                }
            }
            return newArr;
        }

        static int MinEvenOdd(int[] arr, string type)
        {
            int minIndex = -1;
            int currMin = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((type == "even" && arr[i] % 2 == 0) || (type == "odd" && arr[i] % 2 == 1))
                {
                    if (arr[i] <= currMin)
                    {
                        minIndex = i;
                        currMin = arr[i];
                    }
                }
            }

            return minIndex;

        }

        static int MaxEvenOdd(int[] arr, string type)
        {
            int maxIndex = -1;
            int currMax = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((type == "even" && arr[i] % 2 == 0) || (type == "odd" && arr[i] % 2 == 1))
                {
                    if (arr[i] >= currMax)
                    {
                        currMax = arr[i];
                        maxIndex = i;
                    }
                }
            }

            return maxIndex;
        }

        static int[] ExchangeArray(int[] arr, int index)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                index++;
                if (index >= newArr.Length) index = 0;
                newArr[i] = arr[index];
            }

            return newArr;
        }
    }
}
