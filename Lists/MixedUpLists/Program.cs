using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToList();

            List<int> secondList = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToList();


            int smallerListCount = Math.Min(firstList.Count, secondList.Count);

          

            List<int> combinedList = new List<int>(smallerListCount);

            secondList.Reverse();

            for (int i = 0; i < smallerListCount; i++)
            {
                combinedList.Add(firstList[i]);
                combinedList.Add(secondList[i]);
            }

            int constraintOne = 0;
            int constraintTwo = 0;

            if (firstList.Count > secondList.Count)
            {
                constraintOne = firstList[firstList.Count - 1];
                constraintTwo = firstList[firstList.Count - 2];
            }
            else
            {
                constraintOne = secondList[secondList.Count - 1];
                constraintTwo = secondList[secondList.Count - 2];
            }


            int smallerConstraintNum = Math.Min(constraintTwo, constraintOne);
            int biggerConstraintNum = Math.Max(constraintTwo, constraintOne);

            List<int> listToPrint = new List<int>(20);

            

            listToPrint = combinedList.Where(n => n > smallerConstraintNum && n < biggerConstraintNum).ToList();

            listToPrint.Sort();

            Console.WriteLine(string.Join(" ", listToPrint));
        }
    }
}
