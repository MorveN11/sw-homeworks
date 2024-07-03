using Calculator.Utils;

namespace Test;

public class CalculatorTest
{
    private readonly Calculator.Calculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator.Calculator();
        }

        [Fact]
        public void PerformOperation_Addition_ReturnsCorrectResult()
        {
            // Define inputs and outputs
            var operation = Operation.Add;
            double value1 = 3;
            double value2 = 4;
            double expected = 7;

            // Execute actual operation
            var result = _calculator.PerformOperation(operation, value1, value2);

            // Validate response
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformOperation_Subtraction_ReturnsCorrectResult()
        {
            // Define inputs and outputs
            var operation = Operation.Subtraction;
            double value1 = 10;
            double value2 = 4;
            double expected = 6;

            // Execute actual operation
            var result = _calculator.PerformOperation(operation, value1, value2);

            // Validate response
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformOperation_Multiplication_ReturnsCorrectResult()
        {
            // Define inputs and outputs
            var operation = Operation.Multiplication;
            double value1 = 2;
            double value2 = 5;
            double expected = 10;

            // Execute actual operation
            var result = _calculator.PerformOperation(operation, value1, value2);

            // Validate response
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformOperation_Division_ReturnsCorrectResult()
        {
            // Define inputs and outputs
            var operation = Operation.Division;
            double value1 = 10;
            double value2 = 2;
            double expected = 5;

            // Execute actual operation
            var result = _calculator.PerformOperation(operation, value1, value2);

            // Validate response
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformOperation_Pow_ReturnsCorrectResult()
        {
            // Define inputs and outputs
            var operation = Operation.Pow;
            double value1 = 2;
            double value2 = 3;
            double expected = 8;

            // Execute actual operation
            var result = _calculator.PerformOperation(operation, value1, value2);

            // Validate response
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformOperation_SquareRoot_ReturnsCorrectResult()
        {
            // Define inputs and outputs
            var operation = Operation.SquareRoot;
            double value = 16;
            double expected = 4;

            // Execute actual operation
            var result = _calculator.PerformOperation(operation, value);

            // Validate response
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformExpressionCalculation_SimpleExpression_ReturnsCorrectResult()
        {
            // Define inputs and outputs
            var expression = "2+3";
            double expected = 5;

            // Execute actual operation
            var result = _calculator.PerformExpressionCalculation(expression);

            // Validate response
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformExpressionCalculation_MixedOperations_ReturnsCorrectResult()
        {
            // Define inputs and outputs
            var expression = "2+3*4";
            double expected = 14; // Assuming operations are evaluated left to right without precedence handling

            // Execute actual operation
            var result = _calculator.PerformExpressionCalculation(expression);

            // Validate response
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformExpressionCalculation_ComplexExpression_ReturnsCorrectResult()
        {
            // Define inputs and outputs
            var expression = "6/2+5*3";
            double expected = 18; 

            // Execute actual operation
            var result = _calculator.PerformExpressionCalculation(expression);

            // Validate response
            Assert.Equal(expected, result);
        }
}