using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            GetBookSetNameRef(ref book1, "New Name");

            //Act

            // Assert
            Assert.Equal("New Name", book1.Name);

            
        }

        private void GetBookSetNameRef(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            //Act

            // Assert
            Assert.Equal("Book 1", book1.Name);

            
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void BooksAreSeparateObjects()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            //Act

            // Assert
            Assert.Equal("New Name", book1.Name);

            
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //Act

            // Assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            var upper = MakeUppercase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }
    }
}
