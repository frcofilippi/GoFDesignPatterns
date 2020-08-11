using System;

namespace Facade
{
    public class OldCalculationEngine : IOldCalculationEngine
    {
        public int DoSomething(int x, int y)
        {
            return x + y;
        }
        public int DoSomethingElse(int x, int y, int z)
        {
            return (x + y) * z;
        }
    }
}
