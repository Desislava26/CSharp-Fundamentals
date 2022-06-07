using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal class Program
    {
        static void Main()
        {
           
            var dict = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" : ").ToArray();

                string courseName = command[0];
                string userName = command[1];

                if (!dict.ContainsKey(courseName))
                {
                    dict.Add(courseName, new List<string>());
                    dict[courseName].Add(userName);

                }
                else
                {
                    dict[courseName].Add(userName);
                }

            }


            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var str in item.Value)
                {
                    Console.WriteLine($"-- {str}");
                }
            }


        }



    }
}
