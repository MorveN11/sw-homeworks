using Calculadora.src.Operations.Clases;
using Xunit;

namespace CalculatorTests
{

    public class UnitTest1
    {
        [Fact]
        public void AdditionTest()
        {
            Addition addition = new Addition();

            Assert.Equal(3, addition.Operation(1, 2));
            Assert.Equal(10, addition.Operation(5, 5));
            Assert.Equal(0, addition.Operation(0, 0));
        }

        [Fact]
        public void SubtractionTest()
        {
            Substraction subtraction = new Substraction();

            Assert.Equal(2, subtraction.Operation(5, 3));
            Assert.Equal(-10, subtraction.Operation(5, 15));
            Assert.Equal(0, subtraction.Operation(10, 10));
        }

        [Fact]
        public void MultiplicationTest()
        {
            Multiplication multiplication = new Multiplication();

            Assert.Equal(6, multiplication.Operation(2, 3));
            Assert.Equal(0, multiplication.Operation(5, 0));
            Assert.Equal(-15, multiplication.Operation(5, -3));
            Assert.Equal(100, multiplication.Operation(10, 10));
        }

        [Fact]
        public void DivisionTest()
        {
            Division division = new Division();

            Assert.Equal(5, division.Operation(10, 2));
            Assert.Equal(3, division.Operation(6, 2));
            Assert.Equal(20, division.Operation(100, 5));
            Assert.Equal(-5, division.Operation(-10, 2));
        }

        [Fact]
        public void PowerTest()
        {
            Pow power = new Pow();
            Assert.Equal(27, power.Operation(3, 3));
            Assert.Equal(1, power.Operation(10, 0));
            Assert.Equal(0.25, power.Operation(2, -2));
        }

        [Fact]
        public void SquareRootTest()
        {
            SquareRoot squareRoot = new SquareRoot();

            Assert.Equal(5, squareRoot.Operation(25));
            Assert.Equal(3, squareRoot.Operation(9));
            Assert.Throws<ArgumentException>(() => squareRoot.Operation(-1));
        }
    }
}
