using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NxNMatrix
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Letter(num);

        }
        static void Letter(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }


        }


    }
}