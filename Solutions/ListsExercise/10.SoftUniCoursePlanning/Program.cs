using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> schedule = new List<List<string>>();

            string[] arr = Console.ReadLine().Split(", ");

            for (int i = 0; i < arr.Length; i++)
            {
                schedule.Add(new List<string>() { arr[i] });
            }


            string input = Console.ReadLine();

            while(input != "course start")
            {
                string[] cmdArgs = input.Split(":");
                string cmd = cmdArgs[0];

                if(cmd == "Add")
                {
                    string lessonName = cmdArgs[1];
                    if (schedule.All(lesson => lesson[0] != lessonName))
                    {
                        schedule.Add(new List<string>() { lessonName });
                    }
                }
                else if(cmd == "Insert")
                {
                    string lessonName = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2].ToString());
                    if(schedule.All(lesson => lesson[0] != lessonName))
                    {
                        schedule.Insert(index, new List<string> { lessonName });
                    }
                }
                else if(cmd == "Remove")
                {
                    string lessonName = cmdArgs[1];
                    if(schedule.Any(lesson => lesson[0] == lessonName))
                    {
                        schedule = schedule.Where(lesson => lesson[0] != lessonName).ToList();
                    }
                }
                else if(cmd == "Swap")
                {
                    string lesson1 = cmdArgs[1];
                    string lesson2 = cmdArgs[2];

                    if (schedule.Any(lesson => lesson[0] == lesson1) && schedule.Any(lesson => lesson[0] == lesson2))
                    {
                        int index1 = schedule.IndexOf(schedule.Find(lesson => lesson[0] == lesson1));
                        int index2 = schedule.IndexOf(schedule.Find(lesson => lesson[0] == lesson2));

                        List<string> tempLesson = schedule[index1];
                        schedule[index1] = schedule[index2];
                        schedule[index2] = tempLesson;
                    }
                }
                else if(cmd == "Exercise")
                {
                    string lessonName = cmdArgs[1];
                    
                    if(schedule.All(lesson => lesson[0] != lessonName))
                    {
                        string exercise = $"{lessonName}-Exercise";
                        schedule.Add(new List<string>() { lessonName, exercise });
                    }
                    else if(schedule.Any(lesson => lesson[0] == lessonName))
                    {
                        string exercise = $"{lessonName}-Exercise";
                        if(schedule[schedule.IndexOf(schedule.Find(lesson => lesson[0] == lessonName))].Count == 1)
                        {
                            schedule[schedule.IndexOf(schedule.Find(lesson => lesson[0] == lessonName))].Add(exercise);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            int num = 1;
            for (int i = 0; i < schedule.Count; i++)
            {
                for (int j = 0; j < schedule[i].Count; j++)
                {
                    Console.WriteLine($"{num}.{schedule[i][j]}");
                    num++;
                }
            }
        }
    }
}
