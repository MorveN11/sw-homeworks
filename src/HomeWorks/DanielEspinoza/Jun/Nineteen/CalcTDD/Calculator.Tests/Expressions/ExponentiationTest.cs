using Calculator.Expressions;

namespace Calculator.Tests.Expressions;

public class
ExponentiationTest
{
    [Fact]
    public void ExponentiationTwoNumbersTest()
    {
        // Arrange
        Number numberA = new(5);
        Number numberB = new(5);
        Exponentiation exponentiation = new(numberA, numberB);
        double expectedResult = 3125;

        // Act
        double actualResult = exponentiation.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }


    [Fact]
    public void ConcatenationExponentiationTestFromLeft()
    {
        // Arrange
        Number numberA = new(5);
        Number numberB = new(5);
        Exponentiation exponentiationLeft = new(numberA, numberB);
        Number numberC = new(2);
        Exponentiation exponentiation = new(exponentiationLeft, numberC);
        double expectedResult = 9765625;

        // Act
        double actualResult = exponentiation.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }


     [Fact]
    public void ConcatenationExponentiationTestFromRight()
    {
        // Arrange
        Number numberA = new(2);
        Number numberB = new(3);
        Exponentiation exponentiationRight = new(numberA, numberB);
        Number numberC = new(3);
        Exponentiation exponentiation = new(numberC, exponentiationRight);
        double expectedResult = 6561;

        // Act
        double actualResult = exponentiation.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
