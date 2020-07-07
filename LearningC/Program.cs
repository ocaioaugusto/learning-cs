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
            book.AddGrade(80);
            book.AddGrade(77.4);

            while (input != 'q')
            {
                Console.WriteLine("digite...");
                var input = Console.ReadLine();
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }


            book.ShowStatistics();
        }
    }
}
