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


            book.ShowStatistics();
        }
    }
}
