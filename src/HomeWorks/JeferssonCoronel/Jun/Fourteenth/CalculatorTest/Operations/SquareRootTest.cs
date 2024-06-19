using Calculator.Operations.Concretes;

namespace CalculatorTest;

public class SquareRootTest
{
    [Fact]
    public void SquareRoot_PositiveNumber_ReturnsSquareRoot()
    {
        var squareRoot = new SquareRoot();
        const double a = 16;

        var result = squareRoot.Operate(a);
        Assert.Equal(4, result);
    }

    [Fact]
    public void SquareRoot_Zero_ReturnsZero()
    {
        var squareRoot = new SquareRoot();
        const double a = 0;

        var result = squareRoot.Operate(a);
        Assert.Equal(0, result);
    }

    [Fact]
    public void SquareRoot_NegativeNumber_ThrowsArgumentException()
    {
        var squareRoot = new SquareRoot();
        const double a = -4;

        Assert.Throws<ArgumentException>(() => squareRoot.Operate(a));
    }

    [Fact]
    public void GetSymbol_ReturnsSquareRootSymbol()
    {
        var squareRoot = new SquareRoot();
        var symbol = squareRoot.GetSymbol();

        Assert.Equal("√", symbol);
    }
}