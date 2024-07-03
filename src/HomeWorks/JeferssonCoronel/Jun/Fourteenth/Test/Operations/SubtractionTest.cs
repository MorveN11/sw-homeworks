using Calculator.Operations.Concretes;

namespace Test.Operations;

public class SubtractionTest
{
    [Fact]
    public void VerifyThatYouCanGetOperandsFromSumOperation()
    {
        // Define inputs and outputs
        double number1 = 3;
        double number2 = 4;
        double expected = 2;
        
        // Execute actual operation
        var subtraction = new Subtraction();
        subtraction.SetOperands(number1, number2);
        var actual = subtraction.GetOperands().Count;
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithoutOperands()
    {
        // Define inputs and outputs
        double expected = 0;
        
        // Execute actual operation
        var subtraction = new Subtraction();
        var actual = subtraction.ExecuteOperation();
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithOperands()
    {
        // Define inputs and outputs
        double number1 = 10;
        double number2 = 5;
        double expected = 5;
        
        // Execute actual operation
        var subtraction = new Subtraction();
        subtraction.SetOperands(number1, number2);
        var actual = subtraction.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
}