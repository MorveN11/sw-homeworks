using Calculator.Operations.Concretes;

namespace Test.OperationsTest;

public class RootTests
{
    [Fact]
    public void VerifySquareLogic()
    {
        // Define inputs and outputs
        double index = 2;
        double radicand = 16;
        double expected = 4;
        
        // Execute actual operation
        var squareRoot = new Root(index, radicand);
        var actual = squareRoot.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);   
    }
}