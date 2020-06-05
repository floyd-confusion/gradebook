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

            var clonedBook = book.cloneBook(book, "clonedBook");
            book.AddGrade(10);
            book.AddGrade(11);
            book.AddGrade(6);
            book.AddGrade(9);

            var stats1 = book.GetStatistics();
            var stats2 = clonedBook.GetStatistics();


            Console.WriteLine($"The highest is {stats1.High}");
            Console.WriteLine($"The lowest is {stats1.Low}");
            Console.WriteLine($"The average is {stats1.Average:N1}");
            Console.WriteLine($"The highest is {stats2.High}");
            Console.WriteLine($"The lowest is {stats2.Low}");
            Console.WriteLine($"The average is {stats2.Average:N1}");
            


        }


    }
}
