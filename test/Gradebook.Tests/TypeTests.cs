using System;
using GradeBook;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CanSetNameFromReference ()
        {
            var book1 = GetBook("Book1");
            book1.SetName("Book2"); // I have proposed to remove the first argument from the method SetName. So, test should be rewrite as well

            Assert.Equal("Book2", book1.Name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
           var book1 = GetBook("Book 1"); // GetBook is not 'Production' code. It should not be tested. This method is just added to the tests class.
           var book2 = book1;
           book2.Name = "Book 2";

           Assert.Equal ("Book 2", book1.Name);
           Assert.Equal ("Book 2", book2.Name);
        }

        [Fact]
        public void CloneBookReturnsNewBook()
        {
            var book1 = GetBook("Book1"); // rewrite this test with a proposed implementation of the 'CloneBook'
            var book2 = book1.CloneBook(book1, "Cloned");
            Assert.Same(book1, book2);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
