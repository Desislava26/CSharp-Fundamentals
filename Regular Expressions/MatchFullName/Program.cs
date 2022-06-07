using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    internal class Program
    {
        static void Main()
        {

            string pattern = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";

            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                Console.Write(item + " ");
            }



        }
    }
}
