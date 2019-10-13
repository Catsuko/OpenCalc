using OpenCalc;
using OpenCalc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (CalculatorHost calculator in CalculatorHostProvider.Calculators)
            {
                calculator.X = 5;
                calculator.Y = 6;
                Console.WriteLine(calculator.ToString());
            }

            Console.ReadKey();
        }
    }
}
