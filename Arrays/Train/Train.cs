using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    internal class Train
    {
        static void Main()
        {
           
                int n = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                //Така се пълни празен масив 
                for (int i = 0; i < n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    array[i] += num;


                }
                Console.WriteLine(string.Join(" ", array));
                Console.WriteLine(array.Sum());

            
        }
    }
}
