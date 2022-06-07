using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TopNumber
{
    internal class Program
    {
        static void Main()
        {
            int topInteger = int.Parse(Console.ReadLine());

            First(topInteger);


        }
        static void First(int topInteger)
        {
            int sum = 0;
            int oddcount = 0;
            for (int i = 17; i <= topInteger; i++)
            {
                string iToStr = i + "";

                //for digits
                for (int j = 0; j <= iToStr.Length - 1; j++)
                {
                    if (iToStr[j] % 2 == 0)
                    {

                    }
                    else
                    {
                        oddcount++;
                    }
                    int iToInt = iToStr[j] - '0';

                    sum += iToInt;

                }
                if (sum % 8 == 0)
                {
                    if (oddcount >= 1)
                    {
                        Console.WriteLine(i);
                    }
                }
                sum = 0;
                oddcount = 0;
            }



        }




    }

}