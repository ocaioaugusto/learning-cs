using System;
using System.Collections.Generic;

namespace LearningC
{
    class Program
    {
        public static char input { get; private set; }

        static void Main(string[] args)
        {

            var book = new Book("Testing book");
            book.AddGrade(5);
            book.AddGrade(10);
            book.AddGrade(10);


            book.getStatistics();

            var stats = book.getStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
