using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Messaging
{
    internal class Program
    {

        static void Main()
        {
            List<string> listing = Console.ReadLine().Split().ToList();
            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int sum = 0;
            int indx = 0;
            foreach (var item in listing)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    int num = int.Parse(item[i] + "");
                    sum += num;
                }
                if (sum >= message.Length)
                {
                    indx = sum - message.Length;
                }
                else
                {
                    indx = sum;
                }
                char str = message[indx];
                sb.Append(str);
                message = message.Remove(indx, 1);
                sum = 0;
            }

            Console.WriteLine(sb.ToString());





        }

    }

}

