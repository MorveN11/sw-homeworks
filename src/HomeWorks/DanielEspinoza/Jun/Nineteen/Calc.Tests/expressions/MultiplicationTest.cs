using Calculator.Expressions;

namespace Calc.Tests
{
    public class MultiplicationTest
    {
        [Fact]
        public void MultiplicationNormal()
        {
            Multiplication multiplication = new Multiplication(new Number(2), new Number(3));
            double result = multiplication.Evaluate();
            Assert.Equal(6, result);
        }
    }
}
