using System;
using GradeBook;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        // Add a test when no Grade added
        
        [Fact]
        public void BookCalculatesStats()
        {
            //arrange
            var book = new Book("My book");
            book.AddGrade(10.5);
            book.AddGrade(11.3);
            book.AddGrade(7.3);
            book.AddGrade(9.8);
            
            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(9.725, result.Average, 3);  
            Assert.Equal(11.3, result.High);  
            Assert.Equal(7.3, result.Low);  
        }
    }
}
