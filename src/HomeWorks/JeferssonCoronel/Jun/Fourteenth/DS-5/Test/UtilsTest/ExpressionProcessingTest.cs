using Calculator.Utils;

namespace Test.UtilsTest;
using Xunit;

public class ExpressionProcessingTests
{
    [Fact]
    public void GetOperatorsFromExpression_ValidExpression_ReturnsCorrectOperators()
    {
        // Define inputs and outputs
        var processing = new ExpressionProcessing();
        var evaluatedExpression = "*+-";

        // Execute actual operation
        var result = processing.GetOperatorsFromExpression(evaluatedExpression);

        // Validate response
        Assert.Equal(3, result.Count);
        Assert.Equal("*", result[0].GetSymbol().ToString());
        Assert.Equal("+", result[1].GetSymbol().ToString());
        Assert.Equal("-", result[2].GetSymbol().ToString());
    }

    [Fact]
    public void GetOperatorsFromExpression_ExpressionWithDigits_ReturnsOnlyOperators()
    {
        // Define inputs and outputs
        var processing = new ExpressionProcessing();
        var evaluatedExpression = "*+1-2";

        // Execute actual operation
        var result = processing.GetOperatorsFromExpression(evaluatedExpression);

        // Validate response
        Assert.Equal(3, result.Count);
        Assert.Equal("*", result[0].GetSymbol().ToString());
        Assert.Equal("+", result[1].GetSymbol().ToString());
        Assert.Equal("-", result[2].GetSymbol().ToString());
    }

    [Fact]
    public void GetOperatorsFromExpression_EmptyExpression_ReturnsEmptyList()
    {
        // Define inputs and outputs
        var processing = new ExpressionProcessing();
        var evaluatedExpression = "";

        // Execute actual operation
        var result = processing.GetOperatorsFromExpression(evaluatedExpression);

        // Validate response
        Assert.Empty(result);
    }

    [Fact]
    public void GetOperatorsFromExpression_OnlyDigits_ReturnsEmptyList()
    {
        // Define inputs and outputs
        var processing = new ExpressionProcessing();
        var evaluatedExpression = "123";

        // Execute actual operation
        var result = processing.GetOperatorsFromExpression(evaluatedExpression);

        // Validate response
        Assert.Empty(result);
    }

    [Fact]
    public void GetOperandsFromExpression_ValidExpression_ReturnsCorrectOperands()
    {
        // Define inputs and outputs
        var processing = new ExpressionProcessing();
        var evaluatedExpression = "*+123";

        // Execute actual operation
        var result = processing.GetOperandsFromExpression(evaluatedExpression);

        // Validate response
        Assert.Equal(3, result.Count);
        Assert.Equal(1, result[0]);
        Assert.Equal(2, result[1]);
        Assert.Equal(3, result[2]);
    }

    [Fact]
    public void GetOperandsFromExpression_ExpressionWithOperators_ReturnsOnlyOperands()
    {
        // Define inputs and outputs
        var processing = new ExpressionProcessing();
        var evaluatedExpression = "*1+2-3";

        // Execute actual operation
        var result = processing.GetOperandsFromExpression(evaluatedExpression);

        // Validate response
        Assert.Equal(3, result.Count);
        Assert.Equal(1, result[0]);
        Assert.Equal(2, result[1]);
        Assert.Equal(3, result[2]);
    }

    [Fact]
    public void GetOperandsFromExpression_EmptyExpression_ReturnsEmptyList()
    {
        // Define inputs and outputs
        var processing = new ExpressionProcessing();
        var evaluatedExpression = "";

        // Execute actual operation
        var result = processing.GetOperandsFromExpression(evaluatedExpression);

        // Validate response
        Assert.Empty(result);
    }

    [Fact]
    public void GetOperandsFromExpression_OnlyOperators_ReturnsEmptyList()
    {
        // Define inputs and outputs
        var processing = new ExpressionProcessing();
        var evaluatedExpression = "*+-";

        // Execute actual operation
        var result = processing.GetOperandsFromExpression(evaluatedExpression);

        // Validate response
        Assert.Empty(result);
    }
}