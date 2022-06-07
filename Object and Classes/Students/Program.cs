using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Students
{
    internal class Program
    {
        class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Students(string firstname, string lastname, double grade)
            {
                this.FirstName = firstname;
                this.LastName = lastname;
                this.Grade = grade;

            }


        }


        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> listStud = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                Students oneStud = new Students(command[0], command[1], double.Parse(command[2]));
                listStud.Add(oneStud);
               
            }
            var newList = listStud.OrderByDescending(x => x.Grade);

            foreach (var item in newList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }




        }





    }

}



