using Calculator.Utils;

namespace Test.UtilsTest;

public class ExpressionEvaluatorTest
{
    [Fact]
    public void IsACorrectOperation_ValidOperation_ReturnsTrue()
    {
        // Define inputs and outputs
        var evaluator = new ExpressionEvaluator();
        var validOperation = "1+2-3*4";

        // Execute actual operation
        var actual = evaluator.IsACorrectOperation(validOperation);

        // Validate response
        Assert.True(actual);
    }

    [Fact]
    public void IsACorrectOperation_InvalidOperation_ReturnsFalse()
    {
        // Define inputs and outputs
        var evaluator = new ExpressionEvaluator();
        var invalidOperation = "1++2-3*4";

        // Execute actual operation
        var actual = evaluator.IsACorrectOperation(invalidOperation);

        // Validate response
        Assert.False(actual);
    }

    [Fact]
    public void GetEvaluatedExpression_ValidOperation_ReturnsCorrectExpression()
    {
        // Define inputs and outputs
        var evaluator = new ExpressionEvaluator();
        var operation = "1+2*3-4";
        var expected = "*+-2314";

        // Execute actual operation
        var actual = evaluator.GetEvaluatedExpression(operation);

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetEvaluatedExpression_InvalidOperation_ReturnsEmptyString()
    {
        // Define inputs and outputs
        var evaluator = new ExpressionEvaluator();
        var invalidOperation = "1++2-3*4";

        // Execute actual operation
        var actual = evaluator.GetEvaluatedExpression(invalidOperation);

        // Validate response
        Assert.Equal(string.Empty, actual);
    }

    [Fact]
    public void ExtractOperatorsInformation_ValidOperation_ReturnsCorrectDictionary()
    {
        // Define inputs and outputs
        var evaluator = new ExpressionEvaluator();
        var operation = "1+2*3-4";

        // Execute actual operation
        var actual = evaluator.ExtractOperatorsInformation(operation);

        // Validate response
        Assert.Equal(3, actual.Count);
        Assert.Equal('+', actual[1].Symbol);
        Assert.Equal('*', actual[3].Symbol);
        Assert.Equal('-', actual[5].Symbol);
        Assert.True(actual[3].Precedence < actual[1].Precedence);
        Assert.True(actual[3].Precedence < actual[5].Precedence);
    }

    [Fact]
    public void ExtractOperandsIndex_ValidOperation_ReturnsCorrectList()
    {
        // Define inputs and outputs
        var evaluator = new ExpressionEvaluator();
        var operation = "1+2*3-4";

        // Execute actual operation
        var actual = evaluator.ExtractOperandsIndex(operation);

        // Validate response
        Assert.Equal(4, actual.Count);
        Assert.Contains(0, actual);
        Assert.Contains(2, actual);
        Assert.Contains(4, actual);
        Assert.Contains(6, actual);
    }
}