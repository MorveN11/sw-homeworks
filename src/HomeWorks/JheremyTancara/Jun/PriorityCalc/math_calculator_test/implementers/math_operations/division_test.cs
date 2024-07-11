using CalcInterfaces;
using CalcImplementDivision;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestCalcDivision


{
    [TestClass]
    public class TestCalculatorDivision
    {
        int decimalPlaces;

        [TestMethod]
        public void TestDivisionFunctionalityPositives()
        {
            // Inputs and outputs
            double number_one = 10;
            double number_two = 5;
            double expected_result = 2;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestDivisionFunctionalityNegatives()
        {
            // Inputs and outputs
            double number_one = -5;
            double number_two = 5;
            double expected_result = -1;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = 3;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestDivisionWithOneDecimalsPositive()
        {
            // Inputs and outputs
            double number_one = 5;
            double number_two = 3;
            double expected_result = 1.7;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = 1;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestDivisionWithOneDecimalsNegative()
        {
            // Inputs and outputs
            double number_one = -8;
            double number_two = 3;
            double expected_result = -2.7;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = 1;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestDivisionWithTwoDecimalsPositive()
        {
            // Inputs and outputs
            double number_one = 5;
            double number_two = 3;
            double expected_result = 1.67;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = 2;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestDivisionWithTwoDecimalsNegative()
        {
            // Inputs and outputs
            double number_one = -8;
            double number_two = 3;
            double expected_result = -2.67;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = 2;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

         [TestMethod]
        public void TestDivisionWithThreeDecimalsPositive()
        {
            // Inputs and outputs
            double number_one = 5;
            double number_two = 3;
            double expected_result = 1.667;

            var validation = new Mock<IValidation>();
             validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = 2;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestDivisionWithThreeDecimalsNegative()
        {
            // Inputs and outputs
            double number_one = -8;
            double number_two = 3;
            double expected_result = -2.667;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = 2;

            double actual_result = calc.Operation(number_one, number_two, decimalPlaces);

            // Validate results
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void TestValidateDivisionByZero()
        {
            // Inputs and outputs
            double number_one = 10;
            double number_two = 0;

            var validation = new Mock<IValidation>();
            validation
                .Setup(x => x.ValidateDivisionByZero(It.IsAny<double>()))
                .Returns(true);

            validation
                .Setup(x => x.ValidateNonNegative(It.IsAny<double>()))
                .Returns(true);

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = 3;

            // Validate results
            Assert.ThrowsException<DivideByZeroException>(() => calc.Operation(number_one, number_two, decimalPlaces));
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

            // Execute operations
            ICalculator calc = new Division(validation.Object);
            decimalPlaces = -2;

            // Validate results
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calc.Operation(number_one, number_two, decimalPlaces));
        }
    }
}
