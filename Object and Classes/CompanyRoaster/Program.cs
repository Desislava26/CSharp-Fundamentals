using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompanyRoaster
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Profession { get; set; }
        public Employee(string name, double salary, string profession)
        {
            Name = name;
            Salary = salary;
            Profession = profession;
        }
    }
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
     

            Dictionary<string, List<Employee>> dict = new Dictionary<string, List<Employee>>();

            double average = 0;
            int count = 0;
            double max = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                double salary = double.Parse(input[1]);
                string profession = input[2];
                Employee employee = new Employee(name, salary, profession) { };

            
                if (!dict.ContainsKey(profession))
                {
                    dict[profession] = new List<Employee> { employee };
                }
                else
                {
                    dict[profession].Add(employee);

                }


            }
  
            string highest = "";
            foreach (var item in dict)
            {
                foreach (var it in item.Value)
                {
                    average += it.Salary;
                }
                average = average / item.Value.Count;
                if (average > max)
                {
                    max = average;
                    highest = item.Key;
                }
                average = 0;

            }

            Console.WriteLine($"Highest Average Salary: {highest}");
            foreach (var item in dict[highest].OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }


        }

    }
}




