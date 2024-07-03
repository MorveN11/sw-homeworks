using Calculator.Operations.Concretes;

namespace Test.Operations;

public class MultiplicationTest
{
    [Fact]
    public void VerifyThatYouCanGetOperandsFromSumOperation()
    {
        // Define inputs and outputs
        double number1 = 3;
        double number2 = 4;
        double expected = 2;
        
        // Execute actual operation
        var multiplication = new Multiplication();
        multiplication.SetOperands(number1, number2);
        var actual = multiplication.GetOperands().Count;
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithoutOperands()
    {
        // Define inputs and outputs
        double expected = 0;
        
        // Execute actual operation
        var multiplication = new Multiplication();
        var actual = multiplication.ExecuteOperation();
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithOperands()
    {
        // Define inputs and outputs
        double number1 = 3;
        double number2 = 4;
        double expected = 12;
        
        // Execute actual operation
        var multiplication = new Multiplication();
        multiplication.SetOperands(number1, number2);
        var actual = multiplication.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
}