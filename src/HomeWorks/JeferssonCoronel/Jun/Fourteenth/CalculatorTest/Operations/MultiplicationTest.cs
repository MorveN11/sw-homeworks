using Calculator.Operations.Concretes;

namespace CalculatorTest;

public class MultiplicationTest
{
    [Fact]
    public void Multiplication_TwoNumbers_ReturnsProduct()
    {
        var multiplication = new Multiplication();
        const double a = 5;
        const double b = 10;

        var result = multiplication.Operate(a, b);
        Assert.Equal(50, result);
    }

    [Fact]
    public void Multiplication_MultipleNumbers_ReturnsProduct()
    {
        var multiplication = new Multiplication();
        const double a = 2;
        const double b = 3;
        double[] others = [4, 5];

        var result = multiplication.Operate(a, b, others);
        Assert.Equal(120, result);
    }

    [Fact]
    public void Multiplication_WithZero_ReturnsZero()
    {
        var multiplication = new Multiplication();
        const double a = 10;
        const double b = 0;
        double[] others = { 2, 3 };

        var result = multiplication.Operate(a, b, others);
        Assert.Equal(0, result);
    }

    [Fact]
    public void GetSymbol_ReturnsMultiplicationSymbol()
    {
        var multiplication = new Multiplication();
        var symbol = multiplication.GetSymbol();

        Assert.Equal("*", symbol);
    }
}