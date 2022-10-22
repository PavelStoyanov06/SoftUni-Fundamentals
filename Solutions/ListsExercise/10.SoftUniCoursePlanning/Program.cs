using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            while (input != "course start")
            {
                string[] cmdArgs = input.Split(":").ToArray();
                string cmd = cmdArgs[0];

                if(cmd == "Add")
                {
                    string lessonName = cmdArgs[1];
                    if (!schedule.Contains(lessonName))
                    {
                        schedule.Add(lessonName);
                    }
                }
                else if(cmd == "Insert")
                {
                    string lessonName = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2].ToString());
                    if (!schedule.Contains(lessonName))
                    {
                        schedule.Insert(index, lessonName);
                    }
                }
                else if(cmd == "Remove")
                {
                    string lessonName = cmdArgs[1];
                    if (schedule.Contains(lessonName))
                    {
                        schedule.Remove(lessonName);
                    }
                }
                else if(cmd == "Swap")
                {
                    string firstLesson = cmdArgs[1];
                    string secondLesson = cmdArgs[2];

                    if(schedule.Contains(firstLesson) && schedule.Contains(secondLesson))
                    {
                        string tempName = firstLesson;
                        schedule[schedule.IndexOf(firstLesson)] = secondLesson;
                        if (schedule.Contains(secondLesson + "-Exercise"))
                        {
                            schedule.RemoveAt(schedule.IndexOf(secondLesson + "-Exercise"));
                            if (schedule.IndexOf(secondLesson) >= schedule.Count - 1)
                            {
                                schedule.Add(secondLesson + "-Exercise");
                            }
                            else
                            {
                                schedule.Insert(schedule.IndexOf(secondLesson) + 1, secondLesson + "-Exercise");
                            }
                        }
                        schedule[schedule.IndexOf(secondLesson)] = tempName;
                        if (schedule.Contains(tempName + "-Exercise"))
                        {
                            schedule.RemoveAt(schedule.IndexOf(tempName + "-Exercise"));
                            if (schedule.IndexOf(tempName) >= schedule.Count - 1)
                            {
                                schedule.Add(tempName + "-Exercise");
                            }
                            else
                            {
                                schedule.Insert(schedule.IndexOf(tempName) + 1, tempName + "-Exercise");
                            }
                        }
                    }
                }
                else if(cmd == "Exercise")
                {
                    string lessonName = cmdArgs[1];
                    string lessonExercise = lessonName + "-Exercise";

                    if (!schedule.Contains(lessonExercise))
                    {
                        if (!schedule.Contains(lessonName))
                        {
                            schedule.Add(lessonName);
                        }
                        if(schedule.IndexOf(lessonName) + 1 >= schedule.Count - 1)
                        {
                            schedule.Add(lessonExercise);
                        }
                        else
                        {
                            schedule.Insert(schedule.IndexOf(lessonName) + 1, lessonExercise);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
