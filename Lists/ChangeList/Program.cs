using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChangeList
{
    internal class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();


            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> pass = command.Split().ToList();
                if (pass[0] == "Delete")
                {
                    int num = int.Parse(pass[1]);
                    // wagons.FindAll(x => x == 5, wagons.RemoveAt(x));
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] == num)
                        {
                            wagons.RemoveAt(i);

                        }
                    }


                }
                else if (pass[0] == "Insert")
                {
                    int num1 = int.Parse(pass[1]);
                    int num2 = int.Parse(pass[2]);
                    //wagons.FindAll(x => (x + num) <= maxCapacity);
                    wagons.Insert(num2, num1);
                }
            }
            Console.WriteLine(String.Join(" ", wagons));



        }



    }

}
