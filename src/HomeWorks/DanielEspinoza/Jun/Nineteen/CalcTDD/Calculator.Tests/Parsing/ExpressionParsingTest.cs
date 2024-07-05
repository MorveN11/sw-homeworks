using Calculator.Expressions;
using Calculator.Parsing;

namespace Calculator.Tests.Parsing;


public class ExpressionParsingTest
{

    public readonly IParser _parser;
    public ExpressionParsingTest()
    {
        _parser = new ExpressionParser();
    }
    [Fact]
    public void ParseAdditionExpression()
    {
        // Arrange
        string expression = "+&21,1";

        // Act
        IExpression expressionTree = _parser.Parse(expression);
        // Assert
        Assert.Equal("21 + 1", expressionTree.ToString());
    }


      [Fact]
    public void ParseExpressionWithMultiplicationAndAddition()
    {
        // 12+9*4
        // Arrange
        string expression = "*+&9,4,12";

        // Act
        IExpression expressionTree = _parser.Parse(expression);
        // Assert
        Assert.Equal("9 * 4 + 12", expressionTree.ToString());
    }

    [Fact]
    public void ParseExpressionWithMultiplicationAndDivision()
    {
        // Arrange
        string expression = "/*&9,4,12";

        // Act
        IExpression expressionTree = _parser.Parse(expression);
        // Assert
        Assert.Equal("9 / 4 * 12", expressionTree.ToString());
    }


        [Fact]
    public void ParseExpressionWithExponentAndMod()
    {
        // Arrange
        string expression = "%^&9,4,12";

        // Act
        IExpression expressionTree = _parser.Parse(expression);
        // Assert
        Assert.Equal("9 % 4 ^ 12", expressionTree.ToString());
    }
    [Fact]
    public void ParseExpressionWithAllOperators(){

        // Arrange
        string expression = "/**++&9,4,12,9,123";

        // Act
        IExpression expressionTree = _parser.Parse(expression);
        // Assert
        Assert.Equal("9 * 4 / 12 + 9 + 123", expressionTree.ToString());
    }

}
