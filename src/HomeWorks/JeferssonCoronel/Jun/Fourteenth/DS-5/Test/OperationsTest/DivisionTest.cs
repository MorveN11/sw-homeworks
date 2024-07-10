using Calculator.Operations.Concretes;

namespace Test.OperationsTest;

public class DivisionTests
{
    [Fact]
    public void VerifyDivisionLogic()
    {
        // Define inputs and outputs
        double number1 = 12;
        double number2 = 3;
        double expected = 4;
        
        // Execute actual operation
        var division = new Division(number1, number2);
        var actual = division.ExecuteOperation();
        
        // Validate response
        Assert.Equal(expected, actual);   
    }
}