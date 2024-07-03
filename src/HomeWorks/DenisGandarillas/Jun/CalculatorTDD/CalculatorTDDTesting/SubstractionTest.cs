using CalculatorTDD;

namespace CalculatorTDDTesting
{

    [TestClass]
    public class SubstractionTest
    {

        [TestMethod]
        public void VerifyThatSubtractionIsCorrectOne()
        {
            int number1 = 10;
            int number2 = 5;
            int expected = 5;

            Substraction substraction = new Substraction();

            int actual = substraction.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatSubtractionIsCorrectTwo()
        {
            int number1 = 20;
            int number2 = 10;
            int expected = 10;

            Substraction substraction = new Substraction();

            int actual = substraction.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatSubtractionIsCorrectThree()
        {
            int number1 = -10;
            int number2 = 5;
            int expected = -15;

            Substraction substraction = new Substraction();

            int actual = substraction.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThatSubtractionIsCorrectFour()
        {
            int number1 = 0;
            int number2 = 5;
            int expected = -5;

            Substraction substraction = new Substraction();

            int actual = substraction.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }

    }

}
