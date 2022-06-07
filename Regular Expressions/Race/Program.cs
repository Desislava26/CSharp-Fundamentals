using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Race
{
    internal class Program
    {
        static void Main()
        {

            //string pattern = @"(>>)([A-Z][a-z]+|[a-z]+|[A-Z]+)(<<)(\d+\.\d+|\d+)!(\d+)";

            // Regex regex = new Regex(pattern);
            Dictionary<string, int> diction = new Dictionary<string, int>();

            List<string> names = Console.ReadLine().Split(", ").ToList();
            List<string> newNames = new List<string>();
            StringBuilder sb = new StringBuilder();
            string command;
            int total = 0;

            while ((command = Console.ReadLine()) != "end of race")
            {
                foreach (char ch in command)
                {
                    if (Char.IsLetter(ch))
                    {
                        sb.Append(ch);
                    }
                    else if (Char.IsDigit(ch))
                    {
                        int num = Convert.ToInt32(new string(ch, 1));
                        total += num;
                    }
                }
                if (!diction.ContainsKey(sb.ToString()) && names.Contains(sb.ToString()))
                {
                    diction.Add(sb.ToString(), total);

                }
                else if (names.Contains(sb.ToString()))
                {
                    diction[sb.ToString()] += total;
                }
                sb = new StringBuilder();
                total = 0;
            }

            var ordered = diction.OrderByDescending(x => x.Value);//.ToDictionary(x => x.Value);
            int count = 1;
            string place = "1st";
            foreach (var item in ordered)
            {
                Console.WriteLine($"{place} place: {item.Key}");
                count++;
                if (count == 2)
                {
                    place = "2nd";
                }
                else if (count == 3)
                {
                    place = "3rd";
                }
                else
                {
                    break;
                }

            }


        }
    }
}
