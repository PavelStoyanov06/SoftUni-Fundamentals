using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PhoneShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArgs = input.Split(" - ").ToArray();
                string cmd = cmdArgs[0];
                if(cmd == "Add")
                {
                    string phone = cmdArgs[1];
                    if (!phones.Contains(phone))
                    {
                        phones.Add(phone);
                    }
                }
                else if(cmd == "Remove")
                {
                    string phone = cmdArgs[1];
                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                    }
                }
                else if(cmd == "Bonus phone")
                {
                    string[] newOldPhone = cmdArgs[1].Split(":").ToArray();
                    string oldPhone = newOldPhone[0];
                    string newPhone = newOldPhone[1];

                    if (phones.Contains(oldPhone))
                    {
                        if(phones.IndexOf(oldPhone) == phones.Count - 1)
                        {
                            phones.Add(newPhone);
                        }
                        else
                        {
                            phones.Insert(phones.IndexOf(oldPhone) + 1, newPhone);
                        }
                    }
                }
                else if(cmd == "Last")
                {
                    string phone = cmdArgs[1];
                    if (phones.Contains(phone))
                    {
                        phones.RemoveAt(phones.IndexOf(phone));
                        phones.Add(phone);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", phones));
        }
    }
}
