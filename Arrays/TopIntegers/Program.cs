using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace TopIntegers
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string str = "";
            int l = array.Length - 1;

            string[] array2 = new string[] { };


            for (int i = 0; i <= array.Length - 2; i++)
            {

               
                for (int j = i + 1; j <= i + 1; j++)
                {

                    if (array[i] > array[j])
                    {

                        str += $"{array[i]} ";



                    }


                }
            }
            str += $"{array[array.Length - 1]}";




            Console.WriteLine(str);

        }
    }
}

