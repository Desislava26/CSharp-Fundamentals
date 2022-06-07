using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double result = Letter(num, num2);
            Console.WriteLine($"{result:f2}");
        }
        static double Letter(double num, double num2)
        {
            if (num == 0 || num2 == 0)
            {
                num = 1;
                num2 = 1;
            }
            double sumFirst = 1;
            double sumSecond = 1;
            for (double i = num; i > 0; i--)
            {
                sumFirst *= i;
            }
            for (double i = num2; i > 0; i--)
            {
                sumSecond *= i;
            }
            double res = sumFirst / sumSecond;
       
            return res;


        }


    }
}
