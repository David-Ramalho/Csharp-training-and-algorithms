using System;
using SocialMedia.Entities;
using System.Globalization;

namespace SocialMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a Nice trip");
            Comment c2 = new Comment("Thats cool");

            Post p1 = new Post(
                DateTime.ParseExact("21/06/2018 13:05:44", "DD/MM/YYYY HH:mm:ss", CultureInfo.InvariantCulture),
                "traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.ParseExact("28/07/2018 23:14:19", "DD/MM/YYYY HH:mm:ss", CultureInfo.InvariantCulture),                    
                    "Good night guys",
                    "See you tomorrow",
                    5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);





        }
    }
}
