using Calculator.Expressions;

namespace Calculator.Tests.Expressions;


public class ModTest
{
    [Fact]
    public void ModTwoNumbersTest()
    {
        // Arrange
        Number numberA = new(20);
        Number numberB = new(2);
        Mod Mod = new(numberA, numberB);
        double expectedResult = 0;

        // Act

        double actualResult = Mod.Evaluate();

        // Assert

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ConcatenationModTestFromLeft()
    {
        // Arrange
        Number numberA = new(51);
        Number numberB = new(2);
        Mod ModLeft = new(numberA, numberB);
        Number numberC = new(5);

        Mod Mod = new(ModLeft, numberC);
        double expectedResult = 1;

        // Act
        double actualResult = Mod.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }


        [Fact]
    public void ConcatenationModTestFromRight()
    {
        // Arrange
        Number numberA = new(33);
        Number numberB = new(10);
        Mod ModRight = new(numberA, numberB);
        Number numberC = new(99);

        Mod Mod = new(numberC, ModRight);
        double expectedResult = 0;

        // Act
        double actualResult = Mod.Evaluate();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ModByZeroTest()
    {
        // Arrange
        Number numberA = new(50);
        Number numberB = new(0);
        Mod Mod = new(numberA, numberB);

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Mod.Evaluate());
    }
}
