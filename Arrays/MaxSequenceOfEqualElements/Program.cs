using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int counter = 0;
            int winningCounter = 0;
            int index = 0;
            string number = string.Empty;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                    if (counter > winningCounter)
                    {
                        winningCounter = counter;
                        index = i;
                        number = array[i].ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= winningCounter; i++)
            {
                Console.Write(number + " ");
            }





        }
    }
}
