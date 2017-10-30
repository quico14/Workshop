﻿using System;
using System.Threading;
using ConsoleApplication.ServiceReference;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key to start");
            Console.ReadKey();

            var svc = new ServiceClient();

            var msg = new TvShowOfTheYearMessage() { Name = "Game of Thrones", Year = 2017 };

            var review = new TvShowReviewMessage()
            {
                NameOfGame = "Game of Thrones",
                Review = "Most 1337 show of all time!!1!!1!!"
            };

            svc.Execute(msg);
            Thread.Sleep(250); // This is so that debug output in receiver isn't mixed up by multiple threads
            svc.Execute(review);

            Console.WriteLine("Done! kthxbye");
            Console.ReadKey();
        }
    }
}