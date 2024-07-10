using Calculator;
using Calculator.Utils;

namespace Test.UtilsTest;

public class MyOperationExtensionsTest
{
    [Fact]
    public void VerifyGetSymbolForAddition()
    {
        // Define inputs and outputs
        var operation = Operation.Add;
        var expected = '+';

        // Execute actual operation
        var actual = operation.GetSymbol();

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyGetSymbolForMultiplication()
    {
        // Define inputs and outputs
        var operation = Operation.Multiplication;
        var expected = '*';

        // Execute actual operation
        var actual = operation.GetSymbol();

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyGetPrecedenceForAddition()
    {
        // Define inputs and outputs
        var operation = Operation.Add;
        var expected = 3;

        // Execute actual operation
        var actual = operation.GetPrecedence();

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyGetPrecedenceForMultiplication()
    {
        // Define inputs and outputs
        var operation = Operation.Multiplication;
        var expected = 2;

        // Execute actual operation
        var actual = operation.GetPrecedence();

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyGetOperationBySymbolForAddition()
    {
        // Define inputs and outputs
        var symbol = '+';
        var expected = Operation.Add;

        // Execute actual operation
        var actual = symbol.GetOperationBySymbol();

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyGetOperationBySymbolForMultiplication()
    {
        // Define inputs and outputs
        var symbol = '*';
        var expected = Operation.Multiplication;

        // Execute actual operation
        var actual = symbol.GetOperationBySymbol();

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyGetOperationBySymbolForInvalidSymbol()
    {
        // Define inputs and outputs
        var invalidSymbol = '&';

        // Execute actual operation and validate response
        var exception = Assert.Throws<ArgumentException>(() => invalidSymbol.GetOperationBySymbol());
        Assert.Equal($"Invalid operation symbol: {invalidSymbol}", exception.Message);
    }
}