using CalcInterfaces;
using CalcImplementSubtract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestCalcSubtract


{
    [TestClass]
    public class TestCalculatorSubtract
    {
        int decimalPlaces;

        [TestMethod]
        public void TestSubtractIntegerNumbersPositive()
        {
            // Inputs and outputs
            double number_one = 14;
            double number_two = 12;
            double expected_result = 2;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Subtract(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestSubtractIntegerNumbersNegative()
        {
            // Inputs and outputs
            double number_one = 14;
            double number_two = -12;
            double expected_result = 26;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Subtract(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestSubtractDecimalNumbersPositive()
        {
            // Inputs and outputs
            double number_one = 14.112;
            double number_two = 12.12;
            double expected_result = 1.992;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Subtract(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestSubtractDecimalNumbersNegative()
        {
            // Inputs and outputs
            double number_one = 14.112;
            double number_two = -12.12;
            double expected_result = 26.232;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Subtract(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }
    }
}
