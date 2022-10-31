using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while(input != "end")
            {
                string[] details = input.Split(" ").ToArray();

                Student student = new Student();
                student.FirstName = details[0];

                student.LastName = details[1];

                student.Age = int.Parse(details[2].ToString());

                student.HomeTown = details[3];


                students.Add(student);

                input = Console.ReadLine();
            }

            string town = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].HomeTown == town)
                {
                    Console.WriteLine($"{students[i].FirstName} {students[i].LastName} is {students[i].Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}
