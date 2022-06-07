using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademy
{
    internal class Program
    {
        static void Main()
        {
           
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, double>();
          

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, grade);
                }
                else
                {
                    Average(dict, name, grade);
                    continue;
                }

            }

            var filter = dict.Where(x => x.Value >= 4.50);
            foreach (var item in filter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

        }

        static void Average(Dictionary<string, double> dict, string name, double grade)
        {
            double count = 1;
            dict[name] += grade;
            count++;
            double avr = dict[name] / count;
            count = 0;
            dict[name] = avr;


        }



    }
}
