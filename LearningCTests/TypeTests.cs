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

        private void SetGetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = getBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        InMemoryBook getBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
