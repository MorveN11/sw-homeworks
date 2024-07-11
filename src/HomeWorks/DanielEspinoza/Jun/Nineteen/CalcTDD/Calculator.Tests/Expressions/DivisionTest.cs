using Calculator.Expressions;

namespace Calculator.Tests.Expressions;


public class DivisionTest
{
    [Fact]
    public void DivideTwoNumbersTest()
    {
        // Arrange
        Number numberA = new(5);
        Number numberB = new(5);
        Division Division = new(numberA, numberB);
        double expectedResult = 1;

        // Act

        double actualResult = Division.Evaluate();

        // Assert

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ConcatenationDivideTestFromLeft()
    {
        // Arrange
        Number numberA = new(50);
        Number numberB = new(2);
        Division DivisionLeft = new(numberA, numberB);
        Number numberC = new(5);

        Division Division = new(DivisionLeft, numberC);
        double expectedResult = 5;

        // Act
        double actualResult = Division.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }


        [Fact]
    public void ConcatenationDivideTestFromRight()
    {
        // Arrange
        Number numberA = new(50);
        Number numberB = new(2);
        Division DivisionRight = new(numberA, numberB);
        Number numberC = new(100);

        Division Division = new(numberC, DivisionRight);
        double expectedResult = 4;

        // Act
        double actualResult = Division.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void DivideByZeroTest()
    {
        // Arrange
        Number numberA = new(50);
        Number numberB = new(0);
        Division Division = new(numberA, numberB);

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Division.Evaluate());
    }
}
