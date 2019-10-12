namespace OpenCalc.Core
{
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
