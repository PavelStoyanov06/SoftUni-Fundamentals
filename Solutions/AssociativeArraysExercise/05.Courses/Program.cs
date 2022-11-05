using System;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input.Split(" : ");
                string course = cmdArgs[0];
                string name = cmdArgs[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(name);
                }
                else
                {
                    courses[course].Add(name);
                }

                input = Console.ReadLine();
            }

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var sub in item.Value)
                {
                    Console.WriteLine($"-- {sub}");
                }
            }
        }
    }
}
