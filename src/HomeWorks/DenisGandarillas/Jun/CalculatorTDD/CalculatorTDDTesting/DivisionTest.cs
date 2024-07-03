using CalculatorTDD;

namespace CalculatorTDDTesting
{

    [TestClass]
    public class DivisionTest
    {

        [TestMethod]
        public void VerifyThanTheDivisionOperationIsCorrectOne()
        {
            int number1 = 10;
            int number2 = 2;
            int expected = 5;

            Division division = new Division();
            int actual = division.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheDivisionOperationIsCorrectTwo()
        {
            int number1 = 20;
            int number2 = 4;
            int expected = 5;

            Division division = new Division();
            int actual = division.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanTheDivisionOperationIsCorrectThree()
        {
            int number1 = 100;
            int number2 = 10;
            int expected = 10;

            Division division = new Division();
            int actual = division.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }
    }

}
