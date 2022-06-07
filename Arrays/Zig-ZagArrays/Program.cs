using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace Zig_ZagArrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstnum = array[0];
                int secondnum = array[1];
                if (i % 2 != 0)
                {
                    arr1[i - 1] = firstnum;
                    arr2[i - 1] = secondnum;
                }
                else
                {
                    arr1[i - 1] = secondnum;
                    arr2[i - 1] = firstnum;
                }

            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));

        }
    }
}

