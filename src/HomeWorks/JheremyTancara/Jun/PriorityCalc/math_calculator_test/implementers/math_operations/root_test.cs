using CalcInterfaces;
using CalcImplementRoot;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestCalcRoot


{
    [TestClass]
    public class TestCalculatorRoot
    {
        int decimalPlaces;

        [TestMethod]
        public void TestPowerIntegerNumbersPositives()
        {
            // Inputs and outputs
            double number_one = 8;
            double number_two = 2;
            double expected_result = 3;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateIndexGreaterThanTwo(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Root(validation.Object);
            decimalPlaces = 0;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestRootDecimalNumbers()
        {
            // Inputs and outputs
            double number_one = 6.25;
            double number_two = 2;
            double expected_result = 2.500;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateIndexGreaterThanTwo(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Root(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestArgumentRootNegative()
        {
            // Inputs and outputs
            double number_one = -16;
            double number_two = 2;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateIndexGreaterThanTwo(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Root(validation.Object);
            decimalPlaces = 3;

            // Validate results
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calc.Operation(number_one, number_two, decimalPlaces));
        }

        [TestMethod]
        public void TestThatVerifyIndexGreaterThanOrEqualToTwo()
        {
            // Inputs and outputs
            double number_one = 16;
            double number_two = -1;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateIndexGreaterThanTwo(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Root(validation.Object);
            decimalPlaces = 3;

            // Validate results
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calc.Operation(number_one, number_two, decimalPlaces));
        }

        [TestMethod]
        public void TestArgumentOutOfRangeException()
        {
            // Inputs and outputs
            double number_one = 10;
            double number_two = 2;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateIndexGreaterThanTwo(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Root(validation.Object);
            decimalPlaces = -2;

            // Validate results
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calc.Operation(number_one, number_two, decimalPlaces));
        }
    }
}
