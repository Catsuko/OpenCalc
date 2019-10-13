using OpenCalc;

namespace OpenCalcComparisons
{
    [CalculatorPlugin("Finds the greater of a and b")]
    public class Greater : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return b > a ? b : a;
        }

        public char GetSymbol()
        {
            return '>';
        }
    }
}
