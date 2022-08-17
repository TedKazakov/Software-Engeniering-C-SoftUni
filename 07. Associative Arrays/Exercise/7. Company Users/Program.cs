using System;
using System.Collections.Generic;

namespace _7._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (cmd != "End")
            {
                string[] tokens = cmd.Split(" -> ");
                string companyName = tokens[0];
                string idOfWorker = tokens[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(idOfWorker);
                }
                else if (!companies[companyName].Contains(idOfWorker))
                {
                    companies[companyName].Add(idOfWorker);
                }
                cmd = Console.ReadLine();

            }
            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var idOfWorker in company.Value)
                {
                    Console.WriteLine("-- " + idOfWorker);
                }
            }
        }
    }
}
