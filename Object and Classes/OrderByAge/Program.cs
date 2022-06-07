using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split().ToArray();
            List<People> listingPeople = new List<People>();

            while (command[0] != "End")
            {
                string name = command[0];
                string IDpeople = command[1];
                int age = int.Parse(command[2]);
                if (listingPeople.Any(x => x.ID == IDpeople))
                {


                }
                People onePerson = new People(name, IDpeople, age);
                listingPeople.Add(onePerson);

                command = Console.ReadLine().Split().ToArray();
            }
            var newListing = listingPeople.OrderBy(x => x.Age);

            foreach (var item in newListing)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }




        }
        static void UpdatingInfo(List<People> listingPeople)
        {


        }

        class People
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public People(string name, string IDpeople, int age)
            {
                this.Name = name;
                this.ID = IDpeople;
                this.Age = age;
            }
        }

    }

}
