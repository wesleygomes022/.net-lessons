using System;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post();
            p1.Moment = DateTime.Now;
            p1.Title = "Good night guys";
            p1.Content = "See you tomorrow";
            p1.Likes = 5;

            Comment c1 = new Comment();
            c1.Text = "Good night";

            Comment c2 = new Comment();
            c2.Text = "May the force be with you";

            p1.Comments.Add(c1);
            p1.Comments.Add(c2);

            Post p2 = new Post(DateTime.Parse("12/21/2018 17:10:35"), 
                "Traveling to New Zealand", 
                "I'm going to visit this wonderful country!", 
                37);

            Comment c3 = new Comment { Text = "Have a nice trip" };
            Comment c4 = new Comment { Text = "Wow, that's awesome!" };

            p2.Comments.Add(c3);
            p2.Comments.Add(c4);

            Console.WriteLine(p1);
            Console.WriteLine("----------------");
            Console.WriteLine(p2);


        }      
    }
}
