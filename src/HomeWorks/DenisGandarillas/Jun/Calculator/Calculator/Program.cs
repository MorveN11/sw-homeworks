using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Execute("-5-10"));
        }
    }
}
