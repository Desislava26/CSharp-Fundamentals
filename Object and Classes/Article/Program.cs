using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Article
{
    internal class Program
    {
        class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            //public Article(string title, string content, string author)
            //{

            //}

        }


        static void Main()
        {
            List<string> listing = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());
            Article artic = new Article()
            {
                Title = listing[0],
                Content = listing[1],
                Author = listing[2],
            };
            List<Article> newArtic = new List<Article>();

            for (int i = 0; i < n; i++)
            {

                // Article artic = new Article(listing[0], listing[1], listing[2]) {};
                List<string> command = Console.ReadLine().Split(": ").ToList();
                if (command[0] == "Edit")
                {
                    command.RemoveAt(0);
                    var comanTo = string.Join(" ", command);
                    artic.Content = comanTo;

                }
                else if (command[0] == "ChangeAuthor")
                {
                    command.RemoveAt(0);
                    var comanTo = string.Join(" ", command);
                    artic.Author = comanTo;
                }
                else if (command[0] == "Rename")
                {
                    command.RemoveAt(0);
                    var comanTo = string.Join(" ", command);
                    artic.Title = comanTo;
                }

            }
            Console.WriteLine($"{artic.Title} - {artic.Content}: {artic.Author}");





        }





    }

}
