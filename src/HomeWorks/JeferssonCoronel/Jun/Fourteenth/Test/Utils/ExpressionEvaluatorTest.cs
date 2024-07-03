using Calculator.Utils;

namespace Test.Utils;

public class ExpressionEvaluatorTest
{
    [Fact]
    public void VerifyThatReturnsTrueForValidOperation()
    {
        // Define inputs and outputs
        var operation = "2+3-4*5";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.IsACorrectOperation(operation);

        // Validate response
        Assert.True(actual);
    }

    [Fact]
    public void VerifyThatReturnsFalseForInvalidOperation()
    {
        // Define inputs and outputs
        var operation = "2++3-4*5";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.IsACorrectOperation(operation);

        // Validate response
        Assert.False(actual);
    }

    [Fact]
    public void VerifyThatReturnsFalseForOperationWithInvalidCharacters()
    {
        // Define inputs and outputs
        var operation = "2+3a-4*5";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.IsACorrectOperation(operation);

        // Validate response
        Assert.False(actual);
    }
    
    [Fact]
    public void VerifyGetEvaluatedExpression_ReturnsCorrectResultForValidOperation()
    {
        // Define inputs and outputs
        var operation = "2+3-4*5";
        var expected = "*+-4523";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.GetEvaluatedExpression(operation);

        // Validate response
        Assert.Equal(expected, actual); 
    }

    [Fact]
    public void VerifyGetEvaluatedExpression_ReturnsEmptyForInvalidOperation()
    {
        // Define inputs and outputs
        var operation = "2++3-4*5";
        var expected = "";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.GetEvaluatedExpression(operation);

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyGetEvaluatedExpression_ReturnsEmptyForOperationWithInvalidCharacters()
    {
        // Define inputs and outputs
        var operation = "2+3a-4*5";
        var expected = "";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.GetEvaluatedExpression(operation);

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyGetEvaluatedExpression_ReturnsEmptyForEmptyString()
    {
        // Define inputs and outputs
        var operation = "";
        var expected = "";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.GetEvaluatedExpression(operation);

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyGetEvaluatedExpression_ReturnsCorrectResultForSingleOperation()
    {
        // Define inputs and outputs
        var operation = "2+3";
        var expected = "+23";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.GetEvaluatedExpression(operation);

        // Validate response
        Assert.Equal(expected, actual); 
    }
    
    [Fact]
    public void VerifyGetEvaluatedExpression_ReturnsCorrectResultForAOperationThatHaveSameOperatorsPrecedence()
    {
        // Define inputs and outputs
        var operation = "2^3+2√3";
        var expected = "^√+2323";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.GetEvaluatedExpression(operation);

        // Validate response
        Assert.Equal(expected, actual); 
    }
    
    [Fact]
    public void VerifyGetEvaluatedExpression_ReturnsCorrectResultForAOperationThatHaveAllOperators()
    {
        // Define inputs and outputs
        var operation = "2+3-2/3*9^3√9";
        var expected = "^√/*+-9392323";

        // Execute actual operation
        var evaluator = new ExpressionEvaluator();
        var actual = evaluator.GetEvaluatedExpression(operation);

        // Validate response
        Assert.Equal(expected, actual); 
    }
}