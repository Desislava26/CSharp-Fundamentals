using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<string> listing = new List<string>();

            string first = input[0];
            string second = input[1];

            string Fisrtshorter = first;
            string Secondshorter = second;
            if (first.Length > second.Length)
            {
                Fisrtshorter = first.Substring(0, first.Length - 1);

            }
            else if (first.Length < second.Length)
            {

                Secondshorter = second.Substring(0, second.Length - 1);
            }

            int total = 0;



            for (int i = 0; i < Fisrtshorter.Length; i++)
            {
                char ai = Fisrtshorter[i];
                int sumF = Fisrtshorter[i];

                for (int j = i; j < Secondshorter.Length; j++)
                {
                    char aj = Secondshorter[j];
                    int sumS = Secondshorter[j];

                    total += sumF * sumS;
                    break;
                }

            }
            if (first.Length != second.Length)
            {
                if (first.Length > second.Length)
                {
                    string firr = first.Substring(Secondshorter.Length);
                    foreach (char ch in firr)
                    {
                        int g = ch;
                        total += g;
                    }

                }
                else
                {
                    string secc = second.Substring(Fisrtshorter.Length);
                    foreach (char ch in secc)
                    {
                        int g = ch;
                        total += g;
                    }
                }

                //Console.WriteLine(total);


            }




            Console.WriteLine(total);
        }
    }
}