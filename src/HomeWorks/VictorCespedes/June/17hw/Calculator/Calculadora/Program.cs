using System;

namespace Calculadora.src.Calculator
{
    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            string expression = "9-3/2";
            Console.WriteLine(calculator.calculate(expression));
            Console.WriteLine(calculator.stringFormater(expression));
        }
    }
}
