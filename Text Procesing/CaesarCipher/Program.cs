using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCipher
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
          
            StringBuilder stringBuilder = new StringBuilder();


            foreach (char ch in input)
            {
                int charValue = ch + 3;
                char charr = (char)charValue;
                stringBuilder.Append(charr);
            }

            Console.WriteLine(stringBuilder.ToString());




        }
    }
}
