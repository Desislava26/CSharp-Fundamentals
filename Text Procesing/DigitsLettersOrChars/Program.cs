using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsLettersOrChars
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();



            char[] wordToChar = word.ToCharArray();
            //string[] wordArray = wordToChar.Select(x => x.ToString()).ToArray();

            StringBuilder characters = new StringBuilder();
            StringBuilder integers = new StringBuilder();
            StringBuilder letters = new StringBuilder();


            foreach (var item in wordToChar)

            {
                if (char.IsLetter(item))

                {
                    letters.Append(item);

                }
                else if (char.IsDigit(item))
                {
                    integers.Append(item);
                }
                else
                {
                    characters.Append(item);
                }
            }

            Console.WriteLine(integers);
            Console.WriteLine(letters);
            Console.WriteLine(characters);

        }
    }
}