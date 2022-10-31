using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _05.Students2Dot0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while(input != "end")
            {
                string[] details = input.Split(" ");

                if(DoesStudentExist(students, details[0], details[1]))
                {
                    Student existingStudent = GetStudent(students, details[0], details[1]);
                    existingStudent.Age = int.Parse(details[2]);
                    existingStudent.HomeTown = details[3];
                }
                else
                {

                    Student student = new Student();

                    student.FirstName = details[0];
                    student.LastName = details[1];

                    student.Age = int.Parse(details[2]);

                    student.HomeTown = details[3];

                    students.Add(student);
                }

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

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach(Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }

        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            if (students.Any(student => student.FirstName == firstName && student.LastName == lastName))
            {
                return true;
            }

            return false;
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set;  }
    }
}
