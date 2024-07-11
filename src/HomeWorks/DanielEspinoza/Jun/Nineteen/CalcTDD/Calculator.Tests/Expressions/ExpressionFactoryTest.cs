using Calculator.Expressions;
using Xunit;

namespace Calculator.Tests.Parsing;
public class ExpressionFactoryTest
{
    [Fact]
    public void CreateExpression_Addition_ReturnsAddition()
    {
        // Arrange
        var number1 = new Number(5);
        var number2 = new Number(5);
        var expected = "5 + 5";

        // Act
        var actual = ExpressionFactory.CreateExpression(number1, "+", number2);

        // Assert
        Assert.IsType<Addition>(actual);
        Assert.Equal(expected, actual.ToString());
    }

    [Fact]
    public void CreateExpression_Subtraction_ReturnsSubtraction()
    {
        // Arrange
        var number1 = new Number(5);
        var number2 = new Number(3);
        var expected = "5 - 3";

        // Act
        var actual = ExpressionFactory.CreateExpression(number1, "-", number2);

        // Assert
        Assert.IsType<Subtraction>(actual);
        Assert.Equal(expected, actual.ToString());
    }

    [Fact]
    public void CreateExpression_Multiplication_ReturnsMultiplication()
    {
        // Arrange
        var number1 = new Number(5);
        var number2 = new Number(3);
        var expected = "5 * 3";

        // Act
        var actual = ExpressionFactory.CreateExpression(number1, "*", number2);

        // Assert
        Assert.IsType<Multiplication>(actual);
        Assert.Equal(expected, actual.ToString());
    }

    [Fact]
    public void CreateExpression_Division_ReturnsDivision()
    {
        // Arrange
        var number1 = new Number(6);
        var number2 = new Number(3);
        var expected = "6 / 3";

        // Act
        var actual = ExpressionFactory.CreateExpression(number1, "/", number2);

        // Assert
        Assert.IsType<Division>(actual);
        Assert.Equal(expected, actual.ToString());
    }

    [Fact]
    public void CreateExpression_Exponentiation_ReturnsExponentiation()
    {
        // Arrange
        var number1 = new Number(2);
        var number2 = new Number(3);
        var expected = "2 ^ 3";

        // Act
        var actual = ExpressionFactory.CreateExpression(number1, "^", number2);

        // Assert
        Assert.IsType<Exponentiation>(actual);
        Assert.Equal(expected, actual.ToString());
    }

    [Fact]
    public void CreateExpression_Mod_ReturnsMod()
    {
        // Arrange
        var number1 = new Number(5);
        var number2 = new Number(3);
        var expected = "5 % 3";

        // Act
        var actual = ExpressionFactory.CreateExpression(number1, "%", number2);

        // Assert
        Assert.IsType<Mod>(actual);
        Assert.Equal(expected, actual.ToString());
    }

    [Fact]
    public void CreateExpression_InvalidOperator_ThrowsInvalidOperationException()
    {
        // Arrange
        var number1 = new Number(5);
        var number2 = new Number(3);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => ExpressionFactory.CreateExpression(number1, "invalid", number2));
    }
}
