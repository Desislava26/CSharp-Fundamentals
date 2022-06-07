using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Family
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Family(string name, int age)
        {
            Name = name;
            Age = age;

        }
    }
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Family> list = new List<Family>();
            int max = int.MinValue;
            string naming = "";

            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split();
                string name = str[0];
                int age = int.Parse((string)str[1]);
                Family person = new Family(name, age) { };
                list.Add(person);

            }
            foreach (Family family in list)
            {
                if (family.Age > max)
                {
                    max = family.Age;
                    naming = family.Name;
                }

            }
            Console.WriteLine($"{naming} {max}");


        }










    }

}

