using Calculator.Expressions;
namespace Calc.Tests;
public class AdditionTest
{
    [Fact]
    public void AdditionNormal()
    {
        Addition addition = new Addition(new Number(2), new Number(3));
        double result = addition.Evaluate();
        Assert.Equal(5, result);
    }
}
