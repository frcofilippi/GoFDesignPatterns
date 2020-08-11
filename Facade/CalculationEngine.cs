namespace Facade
{
    /// <summary>
    /// This is the Facade - it provides a unified interface to the calculation engine
    /// Everyone can understan what the method does with the name 
    /// </summary>
    public class CalculationEngine : IUndrestableCalculationEngineAPI
    {
        private readonly IOldCalculationEngine engine;

        public CalculationEngine(IOldCalculationEngine engine)
        {
            this.engine = engine;
        }

        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return engine.DoSomething(firstNumber, secondNumber);
        }

        public int AddTwoNumbersThenMultiply(int firstNumberToadd, int secondNumberToAdd, int multiplyFactor)
        {
            return engine.DoSomethingElse(firstNumberToadd, secondNumberToAdd, multiplyFactor);
        }
    }
}
