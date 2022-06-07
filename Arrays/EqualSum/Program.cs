using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int sum2 = 0;

            if (array.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }


            for (int i = 0; i <= array.Length - 1; i++)
            {
                sum = array.Take(i).Sum();
                sum2 = array.Skip(i + 1).Sum();

                if (sum == sum2)
                {
                    Console.WriteLine(i);
                    return;
                }

            }

            Console.WriteLine("no");




        }
    }
}
