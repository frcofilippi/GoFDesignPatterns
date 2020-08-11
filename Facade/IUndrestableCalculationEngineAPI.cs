namespace Facade
{
    public interface IUndrestableCalculationEngineAPI
    {
        public int AddTwoNumbers(int firstNumber, int secondNumber);
        public int AddTwoNumbersThenMultiply(int firstNumberToadd, int secondNumberToAdd, int multiplyFactor);
    }
}
