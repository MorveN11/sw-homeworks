using Calculator.Expressions;

namespace Calculator.Tests.Expressions;


public class NumberTest{

    [Fact]
    public void ExecuteNumberTest()
    {
        // Arrange
        Number number = new(5);
        double expectedResult = 5;

        // Act
        double actualResult = number.Evaluate();


        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
