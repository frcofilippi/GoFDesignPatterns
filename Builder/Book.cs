using System;

namespace Builder
{
    public  class Book : IBook
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}