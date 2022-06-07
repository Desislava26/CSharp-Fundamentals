using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingFile
{

    internal class Program
    {
        static void Main()
        {
            string separator = @"\";
            string dot = ".";

            string[] input = Console.ReadLine().Split(separator);
            //List<string> listing = new List<string>();

            string last = input[input.Length - 1];
            string name = last.Split(dot)[0];
            string extention = last.Split(dot)[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extention}");





        }
    }
}
