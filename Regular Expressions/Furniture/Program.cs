using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Furniture
{
    internal class Program
    {
        static void Main()
        {

            string pattern = @"(>>)([A-Z][a-z]+|[a-z]+|[A-Z]+)(<<)(\d+\.\d+|\d+)!(\d+)";

            Regex regex = new Regex(pattern);

            string text = "";

            StringBuilder sb = new StringBuilder();

            while ((text = Console.ReadLine()) != "Purchase")
            {
                sb.Append(text + " ");

            }


            MatchCollection matches = regex.Matches(sb.ToString());
            List<string> classes = new List<string>();


            double all = 0;
            foreach (Match item in matches)
            {
                string furniture = item.Groups[2].Value;
                double price = double.Parse(item.Groups[4].Value);
                double quantity = double.Parse(item.Groups[5].Value);

                classes.Add(furniture);
                all += (double)(price * quantity);

            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in classes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {all:f2}");




        }
    }
}
