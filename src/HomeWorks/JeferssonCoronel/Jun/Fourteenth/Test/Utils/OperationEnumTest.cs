using Calculator.Utils;

namespace Test.Utils;

public class OperationEnumTest
{
    [Fact]
    public void VerifyThatYouCanGetSymbolFromAddOperation()
    {
        // Define inputs and outputs
        var expected = '+';
        
        // Execute actual operation
        var operation = Operation.Add;
        var actual = operation.GetSymbol();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetPrecedenceFromAddOperation()
    {
        // Define inputs and outputs
        var expected = 3;
        
        // Execute actual operation
        var operation = Operation.Add;
        var actual = operation.GetPrecedence();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetSymbolFromDivisionOperation()
    {
        // Define inputs and outputs
        var expected = '/';
        
        // Execute actual operation
        var operation = Operation.Division;
        var actual = operation.GetSymbol();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetPrecedenceFromDivisionOperation()
    {
        // Define inputs and outputs
        var expected = 2;
        
        // Execute actual operation
        var operation = Operation.Division;
        var actual = operation.GetPrecedence();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetSymbolFromMultiplicationOperation()
    {
        // Define inputs and outputs
        var expected = '*';
        
        // Execute actual operation
        var operation = Operation.Multiplication;
        var actual = operation.GetSymbol();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetPrecedenceFromMultiplicationOperation()
    {
        // Define inputs and outputs
        var expected = 2;
        
        // Execute actual operation
        var operation = Operation.Multiplication;
        var actual = operation.GetPrecedence();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetSymbolFromPowOperation()
    {
        // Define inputs and outputs
        var expected = '^';
        
        // Execute actual operation
        var operation = Operation.Pow;
        var actual = operation.GetSymbol();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetPrecedenceFromPowOperation()
    {
        // Define inputs and outputs
        var expected = 1;
        
        // Execute actual operation
        var operation = Operation.Pow;
        var actual = operation.GetPrecedence();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetSymbolFromSquareRootOperation()
    {
        // Define inputs and outputs
        var expected = '√';
        
        // Execute actual operation
        var operation = Operation.SquareRoot;
        var actual = operation.GetSymbol();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetPrecedenceFromSquareRootOperation()
    {
        // Define inputs and outputs
        var expected = 1;
        
        // Execute actual operation
        var operation = Operation.SquareRoot;
        var actual = operation.GetPrecedence();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetSymbolFromSubtractionOperation()
    {
        // Define inputs and outputs
        var expected = '-';
        
        // Execute actual operation
        var operation = Operation.Subtraction;
        var actual = operation.GetSymbol();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void VerifyThatYouCanGetPrecedenceFromSubtractionOperation()
    {
        // Define inputs and outputs
        var expected = 3;
        
        // Execute actual operation
        var operation = Operation.Subtraction;
        var actual = operation.GetPrecedence();
        
        // Validate response
        Assert.Equal(expected, actual);
    }
}