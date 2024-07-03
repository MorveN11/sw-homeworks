using Calculator.Operations.Concretes;

namespace Test.Operations;

public class SquareRootTest
{
    [Fact]
    public void VerifyThatYouCanGetOperandsFromSquareRootOperation()
    {
        // Define inputs and outputs
        double number1 = 3;
        double expected = 1;
        
        // Execute actual operation
        var squareRoot = new SquareRoot();
        squareRoot.SetOperand(number1);
        var actual = squareRoot.GetOperands().Count;
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSquareRootOperationIsPerformedWithoutOperands()
    {
        // Define inputs and outputs
        double expected = 0;
        
        // Execute actual operation
        var squareRoot = new SquareRoot();
        var actual = squareRoot.ExecuteOperation();
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatSquareRootOperationIsPerformedWithOperands()
    {
        // Define inputs and outputs
        double number1 = 64;
        double expected = 8;
        
        // Execute actual operation
        var squareRoot = new SquareRoot();
        squareRoot.SetOperand(number1);
        var actual = squareRoot.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
}