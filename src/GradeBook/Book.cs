using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {   
        //constructor     
        public Book (string name)
        {
            grades = new List<double>();
            Name = name;
        }
        
        public void AddGrade (double grade)
        {
            grades.Add(grade);
        }
        
        //method below calculates average, highest and lowest grade
        public Statistics GetStatistics () 
        {
            //creating new object of type "Statistics"
            var result = new Statistics();
            //setting it's fields to default values
            result.Average = 0.0;
            result.High = 0;
            result.Low = 100; //here can be anything higher than max grade

            foreach (var grade in grades)
            {
                result.Low = Math.Min(result.Low, grade);
                result.High = Math.Max(result.High, grade);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

        public Book cloneBook(Book book, string name)
        {
            book.Name = name;
            return book;

        }

        public void SetName(Book book, string name)
        {
            Name = name;
        }


        List<double> grades;
        public string Name;
    }

}