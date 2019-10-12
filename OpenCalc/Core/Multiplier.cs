namespace OpenCalc.Core
{
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
