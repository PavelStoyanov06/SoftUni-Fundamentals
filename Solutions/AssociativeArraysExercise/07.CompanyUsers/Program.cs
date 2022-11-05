using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();


            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArgs = input.Split(" -> ");
                string company = cmdArgs[0];
                string id = cmdArgs[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                if (!companies[company].Contains(id))
                {
                    companies[company].Add(id);
                }

                input = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
