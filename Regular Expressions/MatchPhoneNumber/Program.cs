using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main()
        {

            string pattern = @"(\+359)(\s|\-)2\2[0-9]{3}\2[0-9]{4}\b";

            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);
            List<string> classes = new List<string>();

            foreach (Match item in matches)
            {
                classes.Add(item.Value);
                //Console.Write(item);
            }
            Console.WriteLine(string.Join(", ", classes));



        }
    }
}
