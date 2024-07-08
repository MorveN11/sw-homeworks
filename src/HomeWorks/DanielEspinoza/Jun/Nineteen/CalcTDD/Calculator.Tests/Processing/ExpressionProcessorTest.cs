using Calculator.Processing;
using Calculator.Parsing;
using Xunit;

namespace Calculator.Tests.Processing
{
    public class ExpressionProcessorTest
    {
        private readonly ExpressionProcessor _expressionProcessor;

        public ExpressionProcessorTest()
        {
            IParser parser = new ExpressionParser();
            IFormatter formatter = new ExpressionFormatter();
            _expressionProcessor = new ExpressionProcessor(formatter, parser);
        }

        [Fact]
        public void EvaluateSimpleSum()
        {
            // Arrange
            string expr = "2+2";
            double expected = 4;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EvaluateSimpleSubtraction()
        {
            // Arrange
            string expr = "5-3";
            double expected = 2;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EvaluateSimpleMultiplication()
        {
            // Arrange
            string expr = "3*4";
            double expected = 12;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EvaluateSimpleDivision()
        {
            // Arrange
            string expr = "10/2";
            double expected = 5;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EvaluateSimpleModulus()
        {
            // Arrange
            string expr = "10%3";
            double expected = 1;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EvaluateSimpleExponentiation()
        {
            // Arrange
            string expr = "2^3";
            double expected = 8;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }

  /*       [Fact]
        public void EvaluateSimpleSquareRoot()
        {
            // Arrange
            string expr = "√16";
            double expected = 4;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }
 */
        [Fact]
        public void EvaluateComplexExpression()
        {
            // Arrange
            string expr = "3+2-5*2";
            double expected = -5;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EvaluateMultipleOperations()
        {
            // Arrange
            string expr = "2-23-2+3*2^5%9";
            double expected = -8;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EvaluateNegativeNumbers()
        {
            // Arrange
            string expr = "-2+3*-4";
            double expected = -14;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EvaluateMixedOperators()
        {
            // Arrange
            string expr = "2^3*14*5";
            double expected = 560;

            // Act
            double actual = _expressionProcessor.ProcessExpression(expr);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
