using System;
using System.Collections.Generic;

namespace  GradeBook
{
    class Book
    {
        public Book(string name) 
        {
            grades = new List<double>();
            Name = name;
        }

         public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatisctics()
        {
            var average = calculateGradeAvg();
            var lowGrade = getLowestGrade();
            var highGrade = getHighestGrade();

            Console.WriteLine($"The name of the book is: {Name}");
            Console.WriteLine($"The average grade is: {average:N2}");
            Console.WriteLine($"The lowest grade is: {lowGrade:N2}");
            Console.WriteLine($"The highest grade is: {highGrade:N2}");
        }

        public double calculateGradeAvg()
        {
            var result = 0.0;
            foreach (var num in grades)
            {
                result += num;
            }

            return result / grades.Count;
        }

        public double getLowestGrade()
        {
            var result = double.MaxValue;
            foreach (var num in grades)
            {
                result = Math.Min(num, result);
            }

            return result;
        }

        public double getHighestGrade()
        {
            var result = double.MinValue;
            foreach (var num in grades)
            {
                result = Math.Max(num, result);
            }

            return result;
        }

        List<double> grades;
        public string Name { get; private set; }
    }
}