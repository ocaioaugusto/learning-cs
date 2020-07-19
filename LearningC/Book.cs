using System;
using System.Collections.Generic;
using static LearningC.Interfaces;

namespace LearningC
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {

        }

        public event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }

    public class InMemoryBook : Book
    {
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddLetterGrade(string letter)
        {
            switch (letter)
            {
                case "A":
                    AddGrade(90);
                    break;
                case "B":
                    AddGrade(80);
                    break;
                case "C":
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                GradeAdded?.Invoke(this, new EventArgs());
            } else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public new GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics()
        {
            var result = new Statistics
            {
                Average = 0.0,
                High = double.MinValue,
                Low = double.MaxValue
            };

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            switch(result.Average)
            {
                case var d when d >= 90:
                    result.Letter = "A";
                    break;
                case var d when d >= 80:
                    result.Letter = "B";
                    break;
                case var d when d >= 70:
                    result.Letter = "C";
                    break;
                case var d when d >= 60:
                    result.Letter = "D";
                    break;
                default:
                    result.Letter = "F";
                    break;
            }
            return result;
        }

        private List<double> grades;

    }
}
