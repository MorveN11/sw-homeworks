using Calculator.Parsing;
using Xunit;

namespace Calculator.Tests.Parsing;

public class ExtractingExpressionComponentsTest
{
    [Fact]
    public void ExtractValidOperatorsExpression()
    {
        // Arrange
        string expression = "2+3*4/5+-6^2";

        // Act
        string[] operators = ExpressionUtils.ExtractOperators(expression);

        // Assert
        Assert.Equal(["+", "*", "/", "+", "^"], operators);
    }

    [Fact]
    public void ExtractOperatorsFromStringWithoutOperators()
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
    public void ExtractOperatorsFromAnInvalidExpression()
    {

        // Arrange
        string expression = "2+3&4/5?-6¿2";
        string[] expected = ["+", "/"];
        // Act
        string[] actual = ExpressionUtils.ExtractOperators(expression);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ExtractNumbersFromValidExpression()
    {
        // Arrange
        string expression = "2+3-4/5^6*2";
        string[] expected = ["2", "3", "-4", "5", "6", "2"];

        // Act
        string[] numbers = ExpressionUtils.ExtractNumbers(expression);

        // Assert
        Assert.Equal(expected, numbers);
    }

    [Fact]
    public void ExtractingFromStringWithoutNumbers()
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
