using Calculator.Operations.Concretes;

namespace CalculatorTest;

public class DivisionTest
{
    [Fact]
    public void Division_TwoNumbers_ReturnsQuotient()
    {
        var division = new Division();
        const double a = 10;
        const double b = 2;

        var result = division.Operate(a, b);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Division_MultipleNumbers_ReturnsQuotient()
    {
        var division = new Division();
        const double a = 100;
        const double b = 2;
        double[] others = { 5, 2 };
        var result = division.Operate(a, b, others);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Division_ByZero_ThrowsDivideByZeroException()
    {
        var division = new Division();
        const double a = 10;
        const double b = 0;

        Assert.Throws<DivideByZeroException>(() => division.Operate(a, b));
    }

    [Fact]
    public void Division_OtherByZero_ThrowsDivideByZeroException()
    {
        var division = new Division();
        const double a = 10;
        const double b = 2;
        double[] others = [5, 0];

        Assert.Throws<DivideByZeroException>(() => division.Operate(a, b, others));
    }

    [Fact]
    public void GetSymbol_ReturnsDivisionSymbol()
    {
        var division = new Division();
        var symbol = division.GetSymbol();

        Assert.Equal("/", symbol);
    }
}