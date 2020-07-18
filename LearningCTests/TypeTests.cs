using System;
using LearningC;
using Xunit;

namespace LearningCTests
{
    public class TypeTests
    {
        [Fact]
        public void SetNameFromReference()
        {
            var book1 = getBook("Book 1");
            SetGetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetGetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = getBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        Book getBook(string name)
        {
            return new Book(name);
        }
    }
}
