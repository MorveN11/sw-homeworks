using Calculator.Operations.Concretes;

namespace Test.Operations;

public class PowTest
{
    [Fact]
    public void VerifyThatYouCanGetOperandsFromSumOperation()
    {
        // Define inputs and outputs
        double number1 = 3;
        double number2 = 4;
        double expected = 2;
        
        // Execute actual operation
        var pow = new Pow();
        pow.SetOperands(number1, number2);
        var actual = pow.GetOperands().Count;
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithoutOperands()
    {
        // Define inputs and outputs
        double expected = 1;
        
        // Execute actual operation
        var pow = new Pow();
        var actual = pow.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSumOperationIsPerformedWithOperands()
    {
        // Define inputs and outputs
        double number1 = 3;
        double number2 = 4;
        double expected = 81;
        
        // Execute actual operation
        var pow = new Pow();
        pow.SetOperands(number1, number2);
        var actual = pow.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
}