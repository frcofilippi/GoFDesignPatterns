using System;

namespace Builder
{
    public interface IBookBuilder
    {
        IBookBuilder setId(Guid id);
        IBookBuilder setName(string name);

        IBook GetBook();
    }

}
