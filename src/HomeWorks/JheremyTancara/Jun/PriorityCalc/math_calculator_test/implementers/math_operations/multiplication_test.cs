using CalcInterfaces;
using CalcImplementMultiplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestCalculatorMultiplication


{
    [TestClass]
    public class TestCalculatorMultiplication
    {
        int decimalPlaces;

        [TestMethod]
        public void TestMultiplicationIntegerNumbersPositive()
        {
            // Inputs and outputs
            double number_one = 18484989;
            double number_two = 3;
            double expected_result = 55454967;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Multiplication(validation.Object);
            decimalPlaces = 0;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestMultiplicationIntegerNumbersNegative()
        {
            // Inputs and outputs
            double number_one = 184373;
            double number_two = -3;
            double expected_result = -553119;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Multiplication(validation.Object);
            decimalPlaces = 0;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestMultiplicationDecimalNumbersPositive()
        {
            // Inputs and outputs
            double number_one = 12.211;
            double number_two = 3;
            double expected_result = 36.633;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Multiplication(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestMultiplicationDecimalNumbersNegative()
        {
            // Inputs and outputs
            double number_one = 1124;
            double number_two = -3.211;
            double expected_result = -3609.164;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Multiplication(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestMultiplicationWithZero()
        {
            // Inputs and outputs
            double number_one = 1124;
            double number_two = 0;
            double expected_result = 0;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Multiplication(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestArgumentOutOfRangeException()
        {
            // Inputs and outputs
            double number_one = 10;
            double number_two = 2;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Multiplication(validation.Object);
            decimalPlaces = -2;

            // Validate results
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calc.Operation(number_one, number_two, decimalPlaces));
        }
    }
}
