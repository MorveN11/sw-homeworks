using CalculatorTDD;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void VerifyThatItIsPosiblePerformAAddition()
        {
            // Inputs and outputs
            double number1 = 10;
            double number2 = 5;
            double expected = 15;

            // Execute actual operation
            var addition = new Addition();
            double actual = addition.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformAAdditionWithDouble()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5;
            double expected = 15.5;

            // Execute actual operation
            var addition = new Addition();
            double actual = addition.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatItIsPosiblePerformAAdditionWithDoubles()
        {
            // Inputs and outputs
            double number1 = 10.5;
            double number2 = 5.5;
            double expected = 16;

            // Execute actual operation
            var substraction = new Addition();
            double actual = substraction.Execute(number1, number2);

            // Validate response
            Assert.AreEqual(expected, actual);
        }
    }
}
