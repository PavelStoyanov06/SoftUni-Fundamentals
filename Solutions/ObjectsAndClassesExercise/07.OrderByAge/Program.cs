using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();
            while(input != "End")
            {
                string[] cmdArgs = input.Split(" ").ToArray();
                string name = cmdArgs[0];
                string id = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);

                if (people.Any(x => x.Id == id))
                {
                    int index = people.IndexOf(people.First(x => x.Id == id));
                    people[index].Name = name;
                    people[index].Age = age;
                    continue;
                }

                people.Add(new Person(name, id, age));
                input = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
