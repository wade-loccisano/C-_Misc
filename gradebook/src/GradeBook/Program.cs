using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("War and Peace GradeBook");
            book.GradeAdded += OnGradeAdded;

            Console.WriteLine("Enter Grades: ");
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Equals("q"))
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Finished accepting grades.");
                }
            }

            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(93.1);

            var stats = book.GetStatistics();

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"The lowest grade is {stats.Low}.");
            Console.WriteLine($"The highest grade is {stats.High}.");
            Console.WriteLine($"The average grade is {stats.Average}.");
            Console.WriteLine($"The letter grade is {stats.Letter}.");

        }

        static void OnGradeAdded(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("The grade was added.");
        }
    }
}
