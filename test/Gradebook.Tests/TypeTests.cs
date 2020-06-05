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
            book1.SetName(book1, "Book2");

            Assert.Equal("Book2", book1.Name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
           var book1 = GetBook("Book 1");
           var book2 = book1;
           book2.Name = "Book 2";

           Assert.Equal ("Book 2", book1.Name);
           Assert.Equal ("Book 2", book2.Name);
        }

        [Fact]
        public void CloneBookReturnsNewBook()
        {
            var book1 = GetBook("Book1");
            var book2 = book1.cloneBook(book1, "Cloned");
            Assert.Same(book1, book2);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
