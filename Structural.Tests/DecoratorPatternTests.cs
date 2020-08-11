using Decorator;
using System;
using Xunit;

namespace Structural.Tests
{
    [Collection("Decorator")]

    public class DecoratorPatternTests
    {
        [Fact]
        public void ShouldAddFunctionality()
        {
            const string bookName = "The beast";
            const string author = "Stefan King";
            LibraryItem item = new Book(bookName, author);

            Assert.Equal($"{item.GetId()}|{bookName}|{author}", item.Display());

            LibraryItem decoratedBook = new BookDecorator(item);

            Assert.Equal($"{item.GetId()}|{bookName}|{author}|{decoratedBook.GetType().Name}", decoratedBook.Display());
        }


    }
}
