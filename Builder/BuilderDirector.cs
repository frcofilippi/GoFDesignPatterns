using System;

namespace Builder
{
    public class BuilderDirector
    {
        private IBookBuilder _builder;
        public BuilderDirector()
        {
            _builder = new RegularBookBuilder();
        }

        public IBook Build()
        { 
            return _builder.setId(Guid.NewGuid()).setName("My new book").GetBook();
        }

    }

}
