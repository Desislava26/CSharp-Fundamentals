using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AminerTask
{
    internal class Program
    {
        static void Main()
        {
            string command;
            Dictionary<string, int> diction = new Dictionary<string, int>();
            while ((command = Console.ReadLine()) != "stop")
            {
                string word = command;
                int value = int.Parse(Console.ReadLine());

                if (!diction.ContainsKey(word))
                {
                    diction.Add(word, value);
                }
                else
                {
                    diction[word] += value;
                }

            }
            foreach (var item in diction)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }



        }


    }
}