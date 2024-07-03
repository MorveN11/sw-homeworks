using CalculatorTDD;

namespace CalculatorTDDTesting
{

    [TestClass]
    public class MultiplicationTest
    {

        [TestMethod]
        public void VerifyThanMultiplicationIsCorrectOne()
        {
            int number1 = 2;
            int number2 = 3;
            int expected = 6;

            Multiplication multiplication = new Multiplication();

            int result = multiplication.Execute(number1, number2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void VerifyThanMultiplicationIsCorrectTwo()
        {
            int number1 = 4;
            int number2 = 8;
            int expected = 32;

            Multiplication multiplication = new Multiplication();

            int result = multiplication.Execute(number1, number2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void VerifyThanMultiplicationIsCorrectThree()
        {
            int number1 = 10;
            int number2 = 5;
            int expected = 50;

            Multiplication multiplication = new Multiplication();

            int result = multiplication.Execute(number1, number2);

            Assert.AreEqual(expected, result);
        }

    }

}
