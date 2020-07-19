using System;
namespace LearningC
{
    public class Interfaces
    {
        public interface IBook
        {
            void AddGrade(double grade);
            Statistics GetStatistics();
            string Name { get; }
            event GradeAddedDelegate GradeAdded;
        }
    }
}
