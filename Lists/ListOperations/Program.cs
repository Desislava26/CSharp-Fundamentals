using System;
using System.Collections.Generic;
using System.Linq;
 
namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> operations = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                string action = commands[0];
                if (action == "Add")
                {
                    int task = int.Parse(commands[1]);
                    operations.Add(task);
                }
                else if (action == "Insert")
                {
                    int task = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index >= 0 && index < operations.Count)
                    {
                        operations.Insert(index, task);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Shift")
                {
                    string direction = commands[1];
                    if (direction == "left")
                    {
                        int task = int.Parse(commands[2]);
                        while (task != 0)
                        {
                            int number = operations[0];
                            operations.RemoveAt(0);
                            operations.Add(number);
                            task--;
                        }
                    }
                    else if (direction == "right")
                    {
                        int task = int.Parse(commands[2]);
                        while (task != 0)
                        {
                            int number = operations[operations.Count - 1];
                            operations.RemoveAt(operations.Count - 1);
                            operations.Insert(0, number);
                            task--;
                        }
                    }
                }
                else if (action == "Remove")
                {
                    int task = int.Parse(commands[1]);
                    if (task >= 0 && task < operations.Count)
                    {
                        operations.RemoveAt(task);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
            }
            Console.WriteLine(String.Join(" ", operations));
        }
    }
}