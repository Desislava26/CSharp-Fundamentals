using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, string>();
            string name = "";
            string number = "";

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "register")
                {
                    name = input[1];
                    number = input[2];
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, number);
                        Console.WriteLine($"{name} registered {number} successfully");
                        continue;

                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {number}");
                        continue;
                    }

                }
                else if (input[0] == "unregister")
                {
                    name = input[1];
                    if (!dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        dict.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }

                }


            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }






        }



    }
}
