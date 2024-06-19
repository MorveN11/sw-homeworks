using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Operations.Concretes;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTest()
        {
            Addition addition = new Addition();

            Assert.AreEqual(3, addition.Operation(1, 2));
            Assert.AreEqual(10, addition.Operation(5, 5));
            Assert.AreEqual(0, addition.Operation(0, 0));
            Assert.AreEqual(-5, addition.Operation(-10, 5));
            Assert.AreEqual(15, addition.Operation(10, 5));
        }

        [TestMethod]
        public void SubtractionTest()
        {
            Substraction subtraction = new Substraction();

            Assert.AreEqual(2, subtraction.Operation(5, 3));
            Assert.AreEqual(-10, subtraction.Operation(5, 15));
            Assert.AreEqual(0, subtraction.Operation(10, 10));
            Assert.AreEqual(-15, subtraction.Operation(-5, 10));
            Assert.AreEqual(5, subtraction.Operation(10, 5));
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Multiplication multiplication = new Multiplication();

            Assert.AreEqual(6, multiplication.Operation(2, 3));
            Assert.AreEqual(0, multiplication.Operation(5, 0));
            Assert.AreEqual(-15, multiplication.Operation(5, -3));
            Assert.AreEqual(100, multiplication.Operation(10, 10));
            Assert.AreEqual(25, multiplication.Operation(5, 5));
        }

        [TestMethod]
        public void DivisionTest()
        {
            Division division = new Division();

            Assert.AreEqual(5, division.Operation(10, 2));
            Assert.AreEqual(3, division.Operation(6, 2));
            Assert.AreEqual(20, division.Operation(100, 5));
            Assert.AreEqual(0.5, division.Operation(1, 2));
            Assert.AreEqual(-5, division.Operation(-10, 2));
        }

        [TestMethod]
        public void PowerTest()
        {
            Pow power = new Pow();

            Assert.AreEqual(8, power.Operation(2, 3));
            Assert.AreEqual(27, power.Operation(3, 3));
            Assert.AreEqual(1, power.Operation(10, 0));
            Assert.AreEqual(0.25, power.Operation(2, -2));
            Assert.AreEqual(1, power.Operation(0, 0));
        }

        [TestMethod]
        public void SquareRootTest()
        {
            // Arrange
            SquareRoot squareRoot = new SquareRoot();

            // Act & Assert
            Assert.AreEqual(5, squareRoot.Operation(25));
            Assert.AreEqual(3, squareRoot.Operation(9));
            Assert.AreEqual(0, squareRoot.Operation(0));
            Assert.ThrowsException<ArgumentException>(() => squareRoot.Operation(-1));
            Assert.AreEqual(10, squareRoot.Operation(100));
        }
    }
}
