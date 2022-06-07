using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;



namespace EncryptSortАndPrintArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                foreach (char j in name)
                {
                    if (j == 'a' || j == 'o' || j == 'e' || j == 'u' || j == 'i' ||
                       j == 'A' || j == 'E' || j == 'I' || j == 'O' || j == 'U')
                    {
                        sum += (int)j * name.Length;
                    }
                    else
                    {
                        sum += (int)j / name.Length;
                    }

                }
                for (int j = i; j <= i; j++)
                {
                    array[j] = sum;
                }
                //Console.WriteLine(sum);
                sum = 0;
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}

