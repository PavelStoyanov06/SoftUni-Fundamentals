using System;
using System.Linq;

namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dog dog = new Dog();

            dog.Breed = "Golen Retriever";
            dog.Name = "Misho";
            dog.Age = 12;
            Console.WriteLine($"{dog.Breed} {Environment.NewLine}{dog.Name} {Environment.NewLine}{dog.Age}");

            Dog dog2 = new Dog();

            dog2.Breed = "Pitbull";
            dog2.Name = "Sus";
            dog2.Age = 1;
            Console.WriteLine($"{dog2.Breed} {Environment.NewLine}{dog2.Name} {Environment.NewLine}{dog2.Age}");

            dog2.Bark();

            Dog jack = new Dog() 
            {
                Name="Jack",
                Breed="Pitbull",
                Age=11 
            };*/

            string[] input = Console.ReadLine().Split().ToArray();
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randNum = rnd.Next(0, input.Length);
                string temp = input[randNum];
                input[randNum] = input[i];
                input[i] = temp;
            }


            Console.WriteLine(String.Join(Environment.NewLine, input));
        }
    }
}
