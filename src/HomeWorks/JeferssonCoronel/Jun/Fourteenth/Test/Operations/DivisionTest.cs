using Calculator.Operations.Concretes;

namespace Test.Operations;

public class DivisionTest
{
    [Fact]
    public void VerifyThatYouCanGetOperandsFromSumOperation()
    {
        // Define inputs and outputs
        double number1 = 4;
        double number2 = 2;
        double expected = 2;
        
        // Execute actual operation
        var division = new Division();
        division.SetOperands(number1, number2);
        var actual = division.GetOperands().Count;
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithoutOperands()
    {
        // Define inputs and outputs
        double expected = 0;
        
        // Execute actual operation
        var division = new Division();
        var actual = division.ExecuteOperation();
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithOperands()
    {
        // Define inputs and outputs
        double number1 = 8;
        double number2 = 2;
        double expected = 4;
        
        // Execute actual operation
        var division = new Division();
        division.SetOperands(number1, number2);
        var actual = division.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
}