using System;

namespace Decorator
{
    public class BookDecorator : Decorator
    {
        public BookDecorator(LibraryItem item) : base(item)
        { }
        
        public override string Display()
        {
            var baseString = base.Display();
            return string.Concat(baseString, $"|{this.GetType().Name}");
        }

        public override Guid GetId()
        {
            return base.GetId();
        }
    }
}
