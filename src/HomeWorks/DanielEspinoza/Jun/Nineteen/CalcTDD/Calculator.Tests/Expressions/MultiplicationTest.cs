using Calculator.Expressions;

namespace Calculator.Tests.Expressions;

public class MultiplicationTest
{

    [Fact]
    public void MultiplyTwoNumbersTest()
    {
        // Arrange
        Number numberA = new(5);
        Number numberB = new(5);
        Multiplication multiplication = new(numberA, numberB);
        double expectedResult = 25;

        // Act

        double actualResult = multiplication.Evaluate();

        // Assert

        Assert.Equal(expectedResult, actualResult);
    }


    [Fact]
    public void ConcatenationMultiplyTestFromLeft()
    {
        // Arrange
        Number numberA = new(5);
        Number numberB = new(5);
        Multiplication multiplicationLeft = new(numberA, numberB);
        Number numberC = new(5);
        double expecedResult = 125;

        // Act
        Multiplication multiplication = new(multiplicationLeft, numberC);
        double actualResult = multiplication.Evaluate();

        // Assert

        Assert.Equal(expecedResult, actualResult);
    }
}
