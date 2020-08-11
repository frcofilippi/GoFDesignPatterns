using System;

namespace Builder
{
    public interface IBook
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

}
