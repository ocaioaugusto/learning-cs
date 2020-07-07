using System;
using System.Collections.Generic;

namespace LearningC
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        private List<double> grades;

        internal void ShowStatistics()
        {
            throw new NotImplementedException();
        }
        private string name;
    }
}
