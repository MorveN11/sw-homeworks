using Calculator.Operations.Concretes;

namespace Test.OperationsTest;

public class MultiplicationTests
{
    [Fact]
    public void VerifyMultiplicationLogic()
    {
        // Define inputs and outputs
        double number1 = 3;
        double number2 = 4;
        double expected = 12;
        
        // Execute actual operation
        var multiplication = new Multiplication(number1, number2);
        var actual = multiplication.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);   
    }
}