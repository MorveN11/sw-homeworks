using Calculator.Utils;
namespace CalculatorTest;

public class StringEvaluatorTest
{
    private readonly StringEvaluator _stringEvaluator = new StringEvaluator();
    
    [Fact]
    public void GetEvaluatedExpression_SimpleAddition_ReturnsCorrectExpression()
    {
        const string operation = "2+3";
        const string expected = "+23";

        var result = _stringEvaluator.GetEvaluatedExpression(operation);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetEvaluatedExpression_MultiplicationAndAddition_ReturnsCorrectExpression()
    {
        const string operation = "2+3*4";
        const string expected = "*+342";

        var result = _stringEvaluator.GetEvaluatedExpression(operation);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetEvaluatedExpression_DivisionAndSubtraction_ReturnsCorrectExpression()
    {
        const string operation = "9-3/2";
        const string expected = "/-329";

        var result = _stringEvaluator.GetEvaluatedExpression(operation);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetEvaluatedExpression_PowerAndSquareRoot_ReturnsCorrectExpression()
    {
        const string operation = "2^3√4";
        const string expected = "^√234";
        
        var result = _stringEvaluator.GetEvaluatedExpression(operation);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetEvaluatedExpression_InvalidOperation_ReturnsEmptyString()
    {
        const string operation = "2+3++";

        var result = _stringEvaluator.GetEvaluatedExpression(operation);
        Assert.Equal(string.Empty, result);
    }
}