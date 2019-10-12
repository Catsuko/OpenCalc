namespace OpenCalc
{
    internal class CalculatorHost
    {
        private readonly ICalculator _calculator;

        public int X { get; set; }
        public int Y { get; set; }

        public CalculatorHost(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int Calculate ()
        {
            return _calculator.Calculate(X, Y);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} = {3}", X, _calculator.GetSymbol(), Y, Calculate());
        }
    }
}
