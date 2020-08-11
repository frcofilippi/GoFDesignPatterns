using System;

namespace Builder
{
    public class RegularBookBuilder : IBookBuilder
    {
        private IBook _book;

        public RegularBookBuilder()
        {
            _book = new Book();
        }
        public IBookBuilder setId(Guid id)
        {
            _book.Id = id;
            return this;
        }

        public IBookBuilder setName(string name)
        {
            _book.Name = name;
            return this;
        }

        public IBook GetBook()
        {
            return _book;
        }
    }

}
