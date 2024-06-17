using Calculator.Operations.Concretes;

namespace CalculatorTest;

public class SubtractionTest
{
    [Fact]
    public void Subtraction_TwoNumbers_ReturnsDifference()
    {
        var subtraction = new Subtraction();
        const double a = 10;
        const double b = 5;

        var result = subtraction.Operate(a, b);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtraction_MultipleNumbers_ReturnsDifference()
    { 
        var subtraction = new Subtraction();
        const double a = 20;
        const double b = 5;
        double[] others = [3, 2];

        var result = subtraction.Operate(a, b, others);
        Assert.Equal(10, result);
    }

    [Fact]
    public void Subtraction_WithNegativeNumbers_ReturnsDifference()
    {
        var subtraction = new Subtraction();
        const double a = -10;
        const double b = -5;

        var result = subtraction.Operate(a, b);
        Assert.Equal(-5, result);
    }

    [Fact]
    public void Subtraction_WithZero_ReturnsSameNumber()
    {
        var subtraction = new Subtraction();
        const double a = 10;
        const double b = 0;

        var result = subtraction.Operate(a, b);
        Assert.Equal(10, result);
    }

    [Fact]
    public void GetSymbol_ReturnsSubtractionSymbol()
    {
        var subtraction = new Subtraction();
        var symbol = subtraction.GetSymbol();

        Assert.Equal("-", symbol);
    }
}