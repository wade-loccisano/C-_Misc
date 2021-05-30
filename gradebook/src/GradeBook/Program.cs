using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("War and Peace");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(93.1);

            var stats = book.GetStatisctics();

            Console.WriteLine($"The lowest grade is {stats.Low}.");
            Console.WriteLine($"The highest grade is {stats.High}.");
            Console.WriteLine($"The average grade is {stats.Average}.");

        }
    }
}
