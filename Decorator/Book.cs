using System;
using System.ComponentModel.DataAnnotations;

namespace Decorator
{
    public class Book : LibraryItem
    {
        private readonly Guid _bookId;
        public Book(string title, string author) : base(title, author)
        {
            _bookId = Guid.NewGuid();
        }

        public override string Display()
        {
            return $"{_bookId}|{GetTitle()}|{GetAuthor()}";
        }

        public override Guid GetId()
        {
            return _bookId;
        }
    }
}
