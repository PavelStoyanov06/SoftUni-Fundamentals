using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace _09.PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<BigInteger> distance = Console.ReadLine().Split().Select(BigInteger.Parse).ToList();


            List<BigInteger> res = new List<BigInteger>();

            while (distance.Count > 0)
            {
                int input = int.Parse(Console.ReadLine());

                if(input < 0)
                {
                    input = 0;
                    res.Add(distance[input]);
                    distance.RemoveAt(input);
                    distance.Insert(input, distance[distance.Count - 1]);
                }
                else if(input >= distance.Count)
                {
                    input = distance.Count - 1;
                    res.Add(distance[input]);
                    distance.RemoveAt(input);
                    distance.Add(distance[0]);
                }
                else
                {
                    res.Add(distance[input]);
                    distance.RemoveAt(input);
                }

                for (int i = 0; i < distance.Count; i++)
                {
                    if (distance[i] <= res[res.Count - 1])
                    {
                        distance[i] += res[res.Count - 1];
                    }
                    else if (distance[i] > res[res.Count - 1])
                    {
                        distance[i] -= res[res.Count - 1];
                    }
                }
            }
            BigInteger sum = 0;
            for (int i = 0; i < res.Count; i++)
            {
                sum += res[i];
            }
            Console.WriteLine(sum);
        }
    }
}
