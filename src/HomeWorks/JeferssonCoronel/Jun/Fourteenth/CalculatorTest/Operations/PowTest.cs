using Calculator.Operations.Concretes;

namespace CalculatorTest;

public class PowTest
{
    [Fact]
    public void Pow_TwoNumbers_ReturnsPower()
    {
        var pow = new Pow();
        const double a = 2;
        const double b = 3;

        var result = pow.Operate(a, b);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Pow_MultipleNumbers_ReturnsPower()
    {
        var pow = new Pow();
        const double a = 2;
        const double b = 3;
        double[] others = { 2 };

        var result = pow.Operate(a, b, others);
        Assert.Equal(64, result);
    }

    [Fact]
    public void Pow_WithZero_ReturnsOne()
    {
        var pow = new Pow();
        const double a = 2;
        const double b = 0;

        var result = pow.Operate(a, b);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Pow_BaseZeroExponentPositive_ReturnsZero()
    {
        var pow = new Pow();
        const double a = 0;
        const double b = 5;

        var result = pow.Operate(a, b);
        Assert.Equal(0, result);
    }

    [Fact]
    public void GetSymbol_ReturnsPowSymbol()
    {
        var pow = new Pow();
        
        var symbol = pow.GetSymbol();
        Assert.Equal("^", symbol);
    }
}