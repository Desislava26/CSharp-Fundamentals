using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HouseParty
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string command;
            List<string> names = new List<string>();
            int counter = 0;
            while (counter != n)
            {
                List<string> pass = Console.ReadLine().Split().ToList();
                if (pass[1] == "is")
                {

                    if (pass[2] == "not")
                    {
                        if (names.Contains(pass[0]))
                        {
                            names.Remove(pass[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{pass[0]} is not in the list!");
                        }
                    }
                    else if (names.Contains(pass[0]))
                    {
                        Console.WriteLine($"{pass[0]} is already in the list!");
                    }
                    else if (pass[2] == "going!")
                    {
                        names.Add(pass[0]);
                    }



                }
                counter++;

            }
            foreach (string itemm in names)
            {
                Console.WriteLine(itemm);
            }
     



        }



    }

}
