using System;

namespace Decorator
{
    public abstract class LibraryItem
    {
        private string _title;
        private string _author;

        public LibraryItem(string title, string author)
        {
            _title = title;
            _author = author;
        }

        public LibraryItem()
        { }

        public abstract string Display();

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public abstract Guid GetId();
    }
}
