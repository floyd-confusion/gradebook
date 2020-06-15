using System;
using System.Collections.Generic;

using System.Linq; // VZ: it is needed for 'Grades.ToList()'

namespace GradeBook
{
    public class Book
    {   
        //constructor     
        public Book (string name)
        {
            grades = new List<double>(); // better to make this initialization along with declaration
            this.Name = name;
        }
        
        public void AddGrade (double grade)
        {
            grades.Add(grade);
        }
        
        //method below calculates average, highest and lowest grade
        public Statistics GetStatistics () 
        {            
            var result = new Statistics()
            {
                Average = 0.0,
                High = 0,
                Low = double.MaxValue // more reliable and more readable
            };

            foreach (var grade in grades)
            {
                result.Low = Math.Min(result.Low, grade);
                result.High = Math.Max(result.High, grade);
                result.Average += grade;
            }
            result.Average /= grades.Count; // you will have an exception "Dividing by zero" if no grades were added

            return result;
        }

        public bool IsEmpty()
        {
            if (this.grades.Count < 1)
            {
                return true;
            }

            return false;
        }

        // better to follow the same code style. All other method names are started from capitalixed letter. So, use CloneBook
        public Book CloneBook(Book book, string name)
        {
            book.Name = name;  // Clone means to create a new book (instance of a class)
            return book;
        }
        
        public Book CloneBook()
        {
            return new Book(this.Name)
            {
                grades = this.grades.ToList() // please, focus atention. I do a 'deep' copy of a grades
            };
        }

        public void SetName(string name)
        {
            // input parameter 'book' is not used
            
            Name = name;
        }

        private List<double> grades;  // you can initialize in here : private List<double> grades = new List<double>();
        
        // VZ: better to use properties. See https://csharpindepth.com/articles/PropertiesMatter for more information

        public string Name {get; set;} // or {get; private set;}
    }

}
