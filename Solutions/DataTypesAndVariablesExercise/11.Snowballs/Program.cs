using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            string result = string.Empty;
            BigInteger maxSnowball = BigInteger.MinusOne;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowball = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality); 
                if(snowball > maxSnowball)
                {
                    maxSnowball = snowball;
                    result = $"{snowballSnow} : {snowballTime} = {snowball} ({snowballQuality})";
                }
            }

            Console.WriteLine(result);
        }
    }
}
