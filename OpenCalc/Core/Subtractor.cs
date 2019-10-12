namespace OpenCalc.Core
{
    internal class Subtractor : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }

        public char GetSymbol()
        {
            return '-';
        }
    }
}
