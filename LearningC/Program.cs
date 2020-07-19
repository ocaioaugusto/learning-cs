using System;
using System.Collections.Generic;
using static LearningC.Interfaces;

namespace LearningC
{
    class Program
    {
        public static char input { get; private set; }

        static void Main(string[] args)
        {

            IBook book = new DiskBook("Testing book");
            book.GradeAdded += OnGradeAdded;
            EnterGrades((Book)book);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        private static void EnterGrades(Book book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or q to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {

                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("grade was added");
        }
    }
}
