using System;

namespace Decorator
{
    public abstract class Decorator : LibraryItem
    {
        private readonly LibraryItem _libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
        }

        public override string Display()
        {
           return _libraryItem.Display();
        }

        public override Guid GetId()
        {
            return _libraryItem.GetId();
        }
    }
}
