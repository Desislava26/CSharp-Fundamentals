using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace CommonElements
{
    class CommonElements
    {
        static void Main()
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            string str2 = "";

            foreach (string i in array2)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    str2 = array1[j];
                    if (i == str2)
                    {
                        Console.Write($"{str2} ");

                    }
                }
            }


        }
    }
}
