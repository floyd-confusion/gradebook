using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("My book");
            book.AddGrade(10);
            book.AddGrade(11);
            book.AddGrade(7);
            book.AddGrade(9);

            var stats = book.GetStatistics();

            Console.WriteLine($"The highest is {stats.High}");
            Console.WriteLine($"The lowest is {stats.Low}");
            Console.WriteLine($"The average is {stats.Average:N1}");

        }
    }
}
