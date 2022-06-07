using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUsers
{
    internal class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command.Split(" -> ").ToArray();
                string name = args[0];
                string id = args[1];

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<string>());
                    dict[name].Add(id);
                }
                else
                {
                    if (dict[name].Contains(id))
                    {
                        continue;
                    }
                    dict[name].Add(id);
                }



            }


            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var str in item.Value)
                {
                    Console.WriteLine($"-- {str}");

                }
            }




        }
    }
}
