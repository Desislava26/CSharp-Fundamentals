using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidUsernames
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> listing = new List<string>();
            bool isValid = false;

            foreach (string item in input)
            {
                if (item.Length >= 3 && item.Length <= 16)
                {

                    foreach (char i in item)
                    {
                        if (char.IsLetterOrDigit(i) || i == '-' || i == '_')
                        {
                            isValid = true;
                            //listing.Add(item);
                        }
                        else
                        {
                            isValid = false;
                            break; ;
                        }

                    }
                    if (isValid)
                    {
                        listing.Add(item);
                    }


                }
            }

            foreach (string item in listing)
            {
                Console.WriteLine(item);

            }

        }
    }
}
