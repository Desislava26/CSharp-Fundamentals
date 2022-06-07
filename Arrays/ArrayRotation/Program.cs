using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace ArrayRotation
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int l = array.Length - 1;
            int[] array2 = new int[l];


            for (int j = 0; j < n; j++)
            {

                int first = array[0];
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    array[i] = array[i + 1];

                }
                array[l] = first;
            }

            Console.WriteLine(string.Join(" ", array));

        }
    }
}
