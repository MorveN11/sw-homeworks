using Calculator.Expressions;

namespace Calculator.Tests.Expressions;


public class SubstractTest
{
    [Fact]
    public void SubtractTwoNumbersTest()
    {
        // Arrange
        Number numberA = new(5);
        Number numberB = new(5);
        Subtraction subtraction = new(numberA, numberB);
        double expectedResult = 0;

        // Act

        double actualResult = subtraction.Evaluate();

        // Assert

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ConcatenationSubtractTestFromLeft()
    {
        // Arrange
        Number numberA = new(12);
        Number numberB = new(12);
        Subtraction SubtractionLeft = new(numberA, numberB);
        Number numberC = new(-7);

        Subtraction Subtraction = new(SubtractionLeft, numberC);
        double expectedResult = 7;

        // Act
        double actualResult = Subtraction.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }


        [Fact]
    public void ConcatenationSubtractTestFromRight()
    {
        // Arrange
        Number numberA = new(50);
        Number numberB = new(2);
        Subtraction SubtractionRight = new(numberA, numberB);
        Number numberC = new(100);

        Subtraction Subtraction = new(numberC, SubtractionRight);
        double expectedResult = 52;

        // Act
        double actualResult = Subtraction.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

}
