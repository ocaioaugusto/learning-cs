
using System;
using LearningC;
using Xunit;

namespace LearningCTests
{
    public class BookTests
    {
        [Fact]
        public void CheckIfGradesMatch()
        {
            var book = new Book("");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var result = book.getStatistics();

            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);

        }
    }
}