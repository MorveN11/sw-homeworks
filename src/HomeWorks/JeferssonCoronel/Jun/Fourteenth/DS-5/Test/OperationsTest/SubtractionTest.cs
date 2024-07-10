using Calculator.Operations.Concretes;

namespace Test.OperationsTest;

public class SubtractionTests
{
    [Fact]
    public void VerifySubtractionLogic()
    {
        // Define inputs and outputs
        double number1 = 8;
        double number2 = 3;
        double expected = 5;
        
        // Execute actual operation
        var subtraction = new Subtraction(number1, number2);
        var actual = subtraction.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);   
    }
}