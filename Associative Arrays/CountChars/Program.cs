using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountChars
{
    internal class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            Dictionary<char, int> diction = new Dictionary<char, int>();

            foreach (var item in text)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    char ch = item[i];
                    if (!diction.ContainsKey(ch))
                    {
                        diction.Add(ch, 0);
                    }
                    diction[ch] += 1;
                }

            }
            foreach (var item in diction)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }





        }


    }
}
