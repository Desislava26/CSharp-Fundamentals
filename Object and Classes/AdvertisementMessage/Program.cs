using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AdvertisementMessage

{
    internal class Program
    {
        class Message
        {
            public string Phrases { get; set; }
            public string Events { get; set; }
            public string Authors { get; set; }

            public string City { get; set; }

          

        }


        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            List<string> events = new List<string>()
            {
              "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> autors = new List<string>()
                {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            List<string> cities = new List<string>()
                 {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            List<Message> MessageList = new List<Message>() { };
            Random random = new Random();
           

            for (int i = 1; i <= n; i++)
            {
                int num1 = random.Next(0, phrases.Count);
                int num2 = random.Next(0, events.Count);
                int num3 = random.Next(0, autors.Count);
                int num4 = random.Next(0, cities.Count);
           
                var phrase = phrases[num1];
                var eventt = events[num2];
                var authorr = autors[num3];
                var city = cities[num4];
                Message message = new Message()
                {
                    Phrases = phrase,
                    Events = eventt,
                    Authors = authorr,
                    City = city,

                };

                MessageList.Add(message);
                Console.WriteLine($"{phrase} {eventt} {authorr} - {city}.");


            }
         



        }





    }

}
