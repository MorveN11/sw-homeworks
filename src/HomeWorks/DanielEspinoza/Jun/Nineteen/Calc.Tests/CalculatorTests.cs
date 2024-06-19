using Calculator.Expressions;
using Calculator.Parser;
using Calculator;

namespace Calc.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculatorNormalAddition()
        {
            string input = "2+3";
            double result = MathCalculator.Calculate(input);
            Assert.Equal(5, result);
        }

        [Fact]
        public void CalculatorNormalSubtraction()
        {
            string input = "5-3";
            double result = MathCalculator.Calculate(input);
            Assert.Equal(2, result);
        }

        [Fact]
        public void CalculatorNormalMultiplication()
        {
            string input = "2*3";
            double result = MathCalculator.Calculate(input);
            Assert.Equal(6, result);
        }

        [Fact]
        public void CalculatorNormalDivision()
        {
            string input = "6/2";
            double result = MathCalculator.Calculate(input);
            Assert.Equal(3, result);
        }

        [Fact]
        public void CalculatorNormalModulo()
        {
            string input = "5%3";
            double result = MathCalculator.Calculate(input);
            Assert.Equal(2, result);
        }

        [Fact]
        public void CalculatorNormalExponentiation()
        {
            string input = "2^3";
            double result = MathCalculator.Calculate(input);
            Assert.Equal(8, result);
        }

        [Fact]
        public void CalculatorNormalNegativeNumber()
        {
            string input = "-3+5";
            double result = MathCalculator.Calculate(input);
            Assert.Equal(2, result);
        }

        [Fact]
        public void CalculatorNormalComplexExpression()
        {
            string input = "2+3*(4-1)";
            double result = MathCalculator.Calculate(input);
            Assert.Equal(11, result);
        }

        [Fact]
        public void CalculatorInvalidInputUnexpectedEnd()
        {
            string input = "2+";
            Exception ex = Assert.Throws<Exception>(() => MathCalculator.Calculate(input));
            Assert.Equal("Number expected at 2 position", ex.Message);
        }

        [Fact]
        public void CalculatorInvalidInputDivideByZero()
        {
            string input = "5/0";
            Exception ex = Assert.Throws<DivideByZeroException>(() => MathCalculator.Calculate(input));
            Assert.Equal("Attempted to divide by zero.", ex.Message);
        }

  

        [Fact]
        public void CalculatorInvalidInputMissingClosingParenthesis()
        {
            string input = "2+(3*4";
            Exception ex = Assert.Throws<Exception>(() => MathCalculator.Calculate(input));
            Assert.Equal("Fatal Unclosed Parenthesis", ex.Message);
        }
    }
}
