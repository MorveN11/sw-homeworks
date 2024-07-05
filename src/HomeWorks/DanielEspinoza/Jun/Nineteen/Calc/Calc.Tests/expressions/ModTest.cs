using Calculator.Expressions;

namespace Calc.Tests
{
    public class ModTest
    {
        [Fact]
        public void ModNormal()
        {
            Mod mod = new Mod(new Number(5), new Number(3));
            double result = mod.Evaluate();
            Assert.Equal(2, result);
        }

        [Fact]
        public void ModByZero()
        {
            Mod mod = new Mod(new Number(5), new Number(0));
            Assert.Throws<DivideByZeroException>(() => mod.Evaluate());
        }
    }
}
