using CalcInterfaces;
using CalcImplementPower;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestCalcPower


{
    [TestClass]
    public class TestCalculatorPower
    {
        int decimalPlaces;

        [TestMethod]
        public void TestPowerIntegerNumbersPositives()
        {
            // Inputs and outputs
            double number_one = 2;
            double number_two = 7;
            double expected_result = 128;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);
            
            // Execute operations
            ICalculator calc = new Power(validation.Object);
            decimalPlaces = 0;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestPowerIntegerNumbersBaseNegative()
        {
            // Inputs and outputs
            double number_one = -2;
            double number_two = 7;
            double expected_result = -128;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);
            
            // Execute operations
            ICalculator calc = new Power(validation.Object);
            decimalPlaces = 0;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestPowerIntegerNumbersExponentNegative()
        {
            // Inputs and outputs
            double number_one = 2;
            double number_two = -7;
            double expected_result = 0;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);
            
            // Execute operations
            ICalculator calc = new Power(validation.Object);
            decimalPlaces = 0;

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
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(false);
            
            // Execute operations
            ICalculator calc = new Power(validation.Object);
            decimalPlaces = -2;

            // Validate results
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calc.Operation(number_one, number_two, decimalPlaces));
        }  
    }
}
