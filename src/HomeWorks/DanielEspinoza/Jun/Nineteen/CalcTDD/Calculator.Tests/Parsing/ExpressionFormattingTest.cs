using Calculator.Parsing;

namespace Calculator.Tests.Parsing;
public class ExpressionFormattingTest
{

    private readonly IFormatter _formatter;

    public ExpressionFormattingTest()
    {
        _formatter = new ExpressionFormatter();
    }



    [Fact]
    public void FormatEmptyExpression()
    {
        // Arrange
        string expression = "";
        string expected = "";

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatSingleNumber()
    {
        // Arrange
        string expression = "42";
        string expected = "&42";

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatSimpleOperation()
    {

        // Arrange
        string expression = "2+5";
        string expected = "+&2,5";

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }



    [Fact]
    public void FormatOperationWithSpaces()
    {
        // Arrange
        string expression = "  10 * 3  ";
        string expected = "*&10,3";

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }




    [Fact]
    public void FormatOperationWithParentheses()
    {
        // Arrange
        string expression = "4 + 6 * 2";
        string expected = "*+&6,4,2";

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }




    [Fact]
    public void FormatExpressionWithMultipleOperators()
    {
        // Arrange
        string expression = "2 / 4 + 3 - 1";
        string expected = "/++&2,4,3,-1";

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }
}
