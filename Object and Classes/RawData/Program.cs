using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{

    internal class Program
    {
        class Car
        {
            public string Model { get; set; }
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }


            public Car(string model, int speed, int power, int weight, string type)
            {
                Model = model;
                EngineSpeed = speed;
                EnginePower = power;
                CargoWeight = weight;
                CargoType = type;


            }

        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] command = new string[] { };
            List<Car> carsFragile = new List<Car>();
            List<Car> carsFlamable = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split().ToArray();
                string model = command[0];
                int speed = int.Parse(command[1]);
                int power = int.Parse(command[2]);
                int weight = int.Parse(command[3]);
                string type = command[4];

                Car car = new Car(model, speed, power, weight, type);
                if (car.CargoType == "fragile")
                {
                    if (car.CargoWeight < 1000)
                    {
                        carsFragile.Add(car);
                    }
                }
                else if (car.CargoType == "flamable")
                {
                    if (car.EnginePower > 250)
                    {
                        carsFlamable.Add(car);
                    }
                }
            }
            string final = Console.ReadLine();
            if (final == "fragile")
            {
                foreach (Car car in carsFragile)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else if (final == "flamable")
            {
                foreach (Car car in carsFlamable)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }






        }










    }

}

