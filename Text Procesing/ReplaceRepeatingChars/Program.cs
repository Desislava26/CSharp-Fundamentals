using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
           
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                string newest = sb.ToString();
                if (str.Length == 1 && str[i] == newest[newest.Length - 1])
                {
                    break;
                }

                string toadd = str[i] + "";
                sb.Append(toadd);
                if (str.Length == 1)
                {
                    break;
                }
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] != str[j])
                    {
                        str = str.Remove(0, 1);
                        break;
                    }
                    else
                    {
                        str = str.Remove(i, j);
                        j--;
                    }
                }
                i = -1;

            }

            Console.WriteLine(sb.ToString());



        }
    }
}
