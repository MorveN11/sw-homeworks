using Calculator.Expressions;

namespace Calc.Tests;

public class DivisionTest
{
    [Fact]
    public void DivideByZero()
    {
        Division division = new Division(new Number(1), new Number(0));
        Assert.Throws<DivideByZeroException>(() => division.Evaluate());
    }
    [Fact]
    public void DivisionNormal()
    {
        Division division = new Division(new Number(6), new Number(2));
        double result = division.Evaluate();
        Assert.Equal(3, result);
    }
}