using System;
using System.Collections.Generic;
using System.Text;

namespace _01.RandomizeWords
{
    public class Dog
    {

        public Dog(string breed = "sus")
        {
            Breed = breed;
        }
        public string Breed { get; set; }
        public string Name { 
            get
            {
                return "Toshko";
            }
        }
        public int Age { get; set; }


        public void Bark()
        {
            Console.WriteLine("woof!");
        }
    }
}
