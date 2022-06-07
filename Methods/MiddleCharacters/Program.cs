using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Letter(str);

        }
        static void Letter(string str)
        {
            string[] arr = new string[str.Length];
            int letterIndexEven = 0;
            int letterEvenNext = 0;
            int letterOdd = 0;
            int index = str.Length;
            if (index % 2 == 0)
            {
                letterIndexEven = (index / 2) - 1;
                letterEvenNext = letterIndexEven + 1;
                for (int i = letterIndexEven; i <= letterEvenNext; i++)
                {

                    Console.Write(str[i]);
                }
            }
            else
            {
                letterOdd = index / 2;

                for (int i = letterOdd; i <= letterOdd; i++)
                {

                    Console.WriteLine(str[i]);
                }

            }
        }


    }
}
