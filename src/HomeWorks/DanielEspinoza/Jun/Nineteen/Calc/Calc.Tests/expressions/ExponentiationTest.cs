using Calculator.Expressions;

namespace Calc.Tests
{
    public class ExponentiationTest
    {
        [Fact]
        public void ExponentiationNormal()
        {
            Exponentiation exponentiation = new Exponentiation(new Number(2), new Number(3));
            double result = exponentiation.Evaluate();
            Assert.Equal(8, result);
        }
    }
}
