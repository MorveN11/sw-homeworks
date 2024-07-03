using Calculator.Operations.Concretes;

namespace Test.Operations;

public class AdditionTest
{
    [Fact]
    public void VerifyThatYouCanGetOperandsFromSumOperation()
    {
        // Define inputs and outputs
        double number1 = 3;
        double number2 = 4;
        double expected = 2;
        
        // Execute actual operation
        var addition = new Addition();
        addition.SetOperands(number1, number2);
        var actual = addition.GetOperands().Count;
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithoutOperands()
    {
        // Define inputs and outputs
        double expected = 0;
        
        // Execute actual operation
        var addition = new Addition();
        var actual = addition.ExecuteOperation();
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithOperands()
    {
        // Define inputs and outputs
        double number1 = 3;
        double number2 = 4;
        double expected = 7;
        
        // Execute actual operation
        var addition = new Addition();
        addition.SetOperands(number1, number2);
        var actual = addition.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
}