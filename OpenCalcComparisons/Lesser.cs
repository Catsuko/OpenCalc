using OpenCalc;

namespace OpenCalcComparisons
{
    [CalculatorPlugin("Finds the lesser of a and b")]
    public class Lesser : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return b < a ? b : a;
        }

        public char GetSymbol()
        {
            return '<';
        }
    }
}
