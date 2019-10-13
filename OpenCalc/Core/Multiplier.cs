namespace OpenCalc.Core
{
    [CalculatorPlugin("Finds the product of a and b")]
    internal class Multiplier : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a * b;
        }

        public char GetSymbol()
        {
            return '*';
        }
    }
}
