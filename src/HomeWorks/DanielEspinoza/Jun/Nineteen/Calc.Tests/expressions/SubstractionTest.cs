using Calculator.Expressions;


namespace Calc.Tests
{
    public class SubtractionTest
    {
        [Fact]
        public void SubtractionNormal()
        {
            Subtraction subtraction = new Subtraction(new Number(5), new Number(3));
            double result = subtraction.Evaluate();
            Assert.Equal(2, result);
        }
    }
}
