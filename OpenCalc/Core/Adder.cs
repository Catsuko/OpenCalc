namespace OpenCalc.Core
{
    [CalculatorPlugin("Finds the sum of a and b")]
    internal class Adder : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }

        public char GetSymbol()
        {
            return '+';
        }
    }
}
