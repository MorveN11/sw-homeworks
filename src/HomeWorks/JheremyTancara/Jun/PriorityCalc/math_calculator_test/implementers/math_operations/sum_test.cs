using CalcInterfaces;
using CalcImplementSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestCalcSum


{
    [TestClass]
    public class TestCalculatorSum
    {
        int decimalPlaces;

        [TestMethod]
        public void TestSumIntegerNumbersPositive()
        {
            // Inputs and outputs
            double number_one = 14;
            double number_two = 12;
            double expected_result = 26;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);
            
            // Execute operations
            ICalculator calc = new Sum(validation.Object);
            decimalPlaces = 0;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestSumIntegerNumbersNegative()
        {
            // Inputs and outputs
            double number_one = 14;
            double number_two = -12;
            double expected_result = 2;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);
            
            // Execute operations
            ICalculator calc = new Sum(validation.Object);
            decimalPlaces = 0;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestSumDecimalNumbersPositive()
        {
            // Inputs and outputs
            double number_one = 14.112;
            double number_two = 12.12;
            double expected_result = 26.232;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);
            
            // Execute operations
            ICalculator calc = new Sum(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestSumDecimalNumbersNegative()
        {
            // Inputs and outputs
            double number_one = -125.431;
            double number_two = 34.123;
            double expected_result = -91.308;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);
            
            // Execute operations
            ICalculator calc = new Sum(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }
    }
}