using Calculator.Parsing;
using Xunit;

namespace Calculator.Tests.Parsing;

public class ExtractingExpressionComponentsTest
{
    [Fact]
    public void ExtractOperatorsValidExpression()
    {
        // Arrange
        string expression = "2+3*4/5+-6^2";

        // Act
        string[] operators = ExpressionUtils.ExtractOperators(expression);

        // Assert
        Assert.Equal(["+", "*", "/", "+", "^"], operators);
    }

    [Fact]
    public void ExtractOperatorsNoOperators()
    {
        // Arrange
        string expression = "123";

        // Act
        string[] operators = ExpressionUtils.ExtractOperators(expression);

        // Assert
        Assert.Empty(operators);
    }

    [Fact]
    public void ExtractOperatorsEmptyExpression()
    {
        // Arrange
        string expression = "";

        // Act
        string[] operators = ExpressionUtils.ExtractOperators(expression);

        // Assert
        Assert.Empty(operators);
    }

    [Fact]
    public void ExtractNumbersValidExpression()
    {
        // Arrange
        string expression = "2+3*4/5-6^2";

        // Act
        string[] numbers = ExpressionUtils.ExtractNumbers(expression);

        // Assert
        Assert.Equal(new string[] { "2", "3", "4", "5", "-6", "2" }, numbers);
    }

    [Fact]
    public void ExtractNumbersNoNumbers()
    {
        // Arrange
        string expression = "+-*/^";

        // Act
        string[] numbers = ExpressionUtils.ExtractNumbers(expression);

        // Assert
        Assert.Empty(numbers);
    }

    [Fact]
    public void ExtractNumbersEmptyExpression()
    {
        // Arrange
        string expression = "";

        // Act
        string[] numbers = ExpressionUtils.ExtractNumbers(expression);

        // Assert
        Assert.Empty(numbers);
    }
}
