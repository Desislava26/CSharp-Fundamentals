using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    internal class Program
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
            Dictionary<string, string> diction = new Dictionary<string, string>();
            diction.Add("shards", "Shadowmourne");
            diction.Add("fragments", "Valanyr");
            diction.Add("motes", "Dragonwrath");
            int norm = 250;
            bool isObitated = false;
            string forCompare = "";
            Dictionary<string, int> toCollect = new Dictionary<string, int>();
            Dictionary<string, int> notjunk = new Dictionary<string, int>();
            notjunk.Add("shards", 0);
            notjunk.Add("motes", 0);
            notjunk.Add("fragments", 0);

            while (true)
            {

                for (int i = 0; i < command.Length; i += 2)
                {
                    int quantity = int.Parse(command[i]);
                    string type = command[i + 1];
                    if (diction.ContainsKey(type))
                    {
                        notjunk[type] += quantity;
                        if (quantity >= norm || notjunk[type] >= norm)
                        {
                            forCompare = type;
                            isObitated = true;
                            break;
                        }

                    }
                    else
                    {
                        if (toCollect.ContainsKey(type))
                        {
                            toCollect[type] += quantity;
                            continue;
                        }
                        toCollect.Add(type, quantity);
                    }
                }
                if (isObitated)
                {
                    break;
                }
                else
                {
                    command = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
                }


            }

            foreach (var item in diction)
            {
                if (item.Key != forCompare)
                {
                    continue;
                }
                else
                {

                    Console.WriteLine($"{item.Value} obtained!");
                    foreach (var i in notjunk)
                    {
                        var value = i.Value;
                        if (i.Key == forCompare)
                        {
                            value = i.Value - norm;
                        }
                        Console.WriteLine($"{i.Key}: {value}");
                    }
                    foreach (var i in toCollect)
                    {
                        Console.WriteLine($"{i.Key}: {i.Value}");
                    }
                    break;
                }

            }




        }



    }
}