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
            int n = int.Parse(Console.ReadLine());
            int l = array.Length - 1;
            for (int i = 0; i < array.Length - 1; i++)
            {

                for (int j = i + 1; j <= l; j++)
                {
                    int firstnum = array[i];
                    int secondnum = array[j];
                    if (firstnum + secondnum == n)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }

                }

            }






        }
    }
}
