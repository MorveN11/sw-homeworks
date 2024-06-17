using Calculator.Operations.Concretes;

namespace CalculatorTest;

public class AdditionTest
{
    [Fact]
    public void Addition_TwoNumbers_ReturnsSum()
    {
        var addition = new Addition();
        const double a = 5;
        const double b = 10;
        
        var result = addition.Operate(a, b);
        Assert.Equal(15, result);
    }

    [Fact]
    public void Addition_MultipleNumbers_ReturnsSum()
    {
        var addition = new Addition();
        const double a = 1;
        const double b = 2;
        double[] others = [3, 4, 5];

        var result = addition.Operate(a, b, others);
        Assert.Equal(15, result);
    }

    [Fact]
    public void GetSymbol_ReturnsAdditionSymbol()
    {
        var addition = new Addition();
        var symbol = addition.GetSymbol();

        Assert.Equal("+", symbol);
    }
}