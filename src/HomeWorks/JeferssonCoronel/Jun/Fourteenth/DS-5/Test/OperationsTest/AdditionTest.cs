using Calculator.Operations.Concretes;

namespace Test.OperationsTest;

public class AdditionTests
{
    [Fact]
    public void VerifySumLogic()
    {
        // Define inputs and outputs
        double number1 = 23;
        double number2 = 3;
        double expected = 26;
        
        // Execute actual operation
        var addition = new Addition(number1, number2);
        var actual = addition.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);   
    }
}