using Calculator.Expressions;

namespace Calc.Tests
{
    public class NegationTest
    {
        [Fact]
        public void NegationNormal()
        {
            Negation negation = new Negation(new Number(5));
            double result = negation.Evaluate();
            Assert.Equal(-5, result);
        }
    }
}
