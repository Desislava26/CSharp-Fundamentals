using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {
            bool isItTrue = false;
         
            Number(isItTrue);

        }
        static void Number(bool isItTrue)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                int num = int.Parse(command);
                int n = num;
                int reverse = 0;
                int rem = 0;


                while (n != 0)
                {
                    rem = n % 10;
                    reverse = reverse * 10 + rem;
                    n /= 10;
                }

                if (num == reverse)
                {
                    isItTrue = true;
                }
                else
                {
                    isItTrue = false;
                }
                string bul = (isItTrue).ToString().ToLower();
                Console.WriteLine(bul);
             
            }
           
        }


    }
}
