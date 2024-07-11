using Calculator.Parsing;
using Moq;

namespace Calculator.Tests.Parsing;
public class ExpressionFormattingTest
{
    private readonly Mock<INormalizer> _normalizerMock;
    private readonly ExpressionFormatter _formatter;

    public ExpressionFormattingTest()
    {
        _normalizerMock = new Mock<INormalizer>();
        _formatter = new ExpressionFormatter(_normalizerMock.Object);
    }

    [Fact]
    public void FormatEmptyExpression()
    {
        // Arrange
        string expression = "";
        string expected = "";

        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

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

        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatSimpleAdditionOperation()
    {

        // Arrange
        string expression = "2+5";
        string expected = "+&2,5";

        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatSimpleAdditionWithNegativeNumbersOperation()
    {

        // Arrange
        string expression = "-2+5";
        string expected = "+&-2,5";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);
        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }



    [Fact]
    public void FormatSimpleSubstractionOperation()
    {

        // Arrange
        string expression = "2-5";
        string expected = "+&2,-5";

        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("2+-5");

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatSimpleSubstractionWithNegativeNumbersOperation()
    {

        // Arrange
        string expression = "-2--5";
        string expected = "+&-2,5";

        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("-2+5");

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatSimpleAdditionWithTwoNegativeNumbersOperation()
    {

        // Arrange
        string expression = "-2+-5";
        string expected = "+&-2,-5";

        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }


    [Fact]
    public void FormatSimpleMultiplicationOperation()
    {

        // Arrange
        string expression = "12*19";
        string expected = "*&12,19";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatSimpleMultiplicationWithNegativeNumbersOperation()
    {

        // Arrange
        string expression = "12*-19";
        string expected = "*&12,-19";

        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }


    [Fact]
    public void FormatSimpleDivisionOperation()
    {

        // Arrange
        string expression = "128/19";
        string expected = "/&128,19";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }




    [Fact]
    public void FormatSimpleDivisionWithNegativeNumbersOperation()
    {

        // Arrange
        string expression = "-128/-19";
        string expected = "/&-128,-19";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }


    [Fact]
    public void FormatSimpleModulusOperation()
    {

        // Arrange
        string expression = "2%4";
        string expected = "%&2,4";

        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }




    [Fact]
    public void FormatSimpleModulusWithNegativeNumbersOperation()
    {

        // Arrange
        string expression = "-2%-4";
        string expected = "%&-2,-4";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }


    [Fact]
    public void FormatSimpleExponentOperation()
    {

        // Arrange
        string expression = "2^4";
        string expected = "^&2,4";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

        // Act

        string actual = _formatter.Format(expression);

        // Assert

        Assert.Equal(expected, actual);
    }


    [Fact]
    public void FormatSimpleExponentWithNegativeNumbersOperation()
    {

        // Arrange
        string expression = "-2^-4";
        string expected = "^&-2,-4";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns(expression);

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
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("10*3");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }




    [Fact]
    public void FormatOperationWithTwoOperators()
    {
        // Arrange
        string expression = "6 * 2+4";
        string expected = "*+&6,2,4";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("6*2+4");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatExpressionWithThreeOperators()
    {
        // Arrange
        string expression = "2 % 4 / 3 + 1";
        string expected = "%/+&2,4,3,1";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("2%4/3+1");
        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void FormatExpressionWithFourOperators()
    {
        // Arrange
        string expression = "6  ^ 2 % 4 / 3+5";
        string expected = "^%/+&6,2,4,3,5";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("6^2%4/3+5");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }



    [Fact]
    public void FormatExpressionWithFiveOperators()
    {
        // Arrange
        string expression = "6  ^ 2 % 4 / 3*  16+ +5";
        string expected = "^%/*+&6,2,4,3,16,5";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("6^2%4/3*16+5");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void FormatExpressionWithSixOperators()
    {
        // Arrange
        string expression = "6  ^ 2 % 4 / 3*178+5 -  +  8";
        string expected = "^%/*++&6,2,4,3,178,5,-8";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("6^2%4/3*178+5+-8");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }





    [Fact]
    public void FormatOperationWithTwoOperatorsAndAGreaterOperationAtTheEnd()
    {
        // Arrange
        string expression = "4 + 6 * 2";
        string expected = "*+&6,2,4";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("4+6*2");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatExpressionWithThreeOperatorsAndAGreaterOperationAtTheEnd()
    {
        // Arrange
        string expression = " 3 + 4 * 12 / 4";
        string expected = "/*+&12,4,4,3";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("3+4*12/4");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void FormatExpressionWithFourOperatorsAndAGreaterOperationAtTheEnd()
    {
        // Arrange
        string expression = "4 + 6 * 2 / 4 ^ 3";
        string expected = "^/*+&4,3,2,6,4";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("4+6*2/4^3");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void FormatExpressionWithFiveOperatorsAndAGreaterOperationAtTheEnd()
    {
        // Arrange
        string expression = "4 + 6 * 2 / 4 % 3 ^ 5";
        string expected = "^%/*+&3,5,4,2,6,4";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("4+6*2/4%3^5");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FormatExpressionWithSixOperatorsAndAGreaterOperationAtTheEnd()
    {
        // Arrange
        string expression = "12 - 4 + 6 * 2 / 4 % 3 ^ 5";
        string expected = "^%/*++&3,5,4,2,6,12,-4";
        _normalizerMock.Setup(x => x.Normalize(expression)).Returns("12+-4+6*2/4%3^5");

        // Act
        string actual = _formatter.Format(expression);

        // Assert
        Assert.Equal(expected, actual);
    }

}
