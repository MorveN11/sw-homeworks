using CalculatorTDD;

namespace CalculatorTDDTesting
{
    [TestClass]
    public class AdditionTest
    {

        [TestMethod]
        public void VerifyThanAdditionIsCorrectOne()
        {
            int number1 = 2;
            int number2 = 3;
            int expected = 5;

            Addition addition = new Addition();

            int actual = addition.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanAdditionIsCorrectTwo()
        {
            int number1 = 102;
            int number2 = 383;
            int expected = 485;

            Addition addition = new Addition();

            int actual = addition.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerifyThanAdditionIsCorrectThree()
        {
            int number1 = 862_616;
            int number2 = 188_010;
            int expected = 1_050_626;

            Addition addition = new Addition();

            int actual = addition.Execute(number1, number2);

            Assert.AreEqual(expected, actual);
        }

    }
}
