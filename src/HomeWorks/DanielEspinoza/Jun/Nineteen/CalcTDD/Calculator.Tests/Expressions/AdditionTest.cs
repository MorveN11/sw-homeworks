using Calculator.Expressions;

namespace Calculator.Tests.Expressions;


public class AdditionTest
{
    [Fact]
    public void AddTwoNumbersTest()
    {
        // Arrange
        Number numberA = new(5);
        Number numberB = new(5);
        Addition addition = new(numberA, numberB);
        double expectedResult = 10;

        // Act

        double actualResult = addition.Evaluate();

        // Assert

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void AdditionConcatenationTest()
    {
        // Arrange
        Number numberA = new(5);
        Number numberB = new(5);
        Addition additionLeft = new(numberA, numberB);
        Number numberC = new(5);

        Addition addition = new(additionLeft, numberC);
        double expectedResult = 15;

        // Act
        double actualResult = addition.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
