namespace OpenCalc.Core
{
    [CalculatorPlugin("Divides a by b")]
    internal class Divider : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a / b;
        }

        public char GetSymbol()
        {
            return '/';
        }
    }
}
