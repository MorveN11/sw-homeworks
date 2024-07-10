using Calculator;

namespace Test;

public class OperationTest
{
    [Fact]
    public void VerifyEnumValuesExist()
    {
        // Define inputs and outputs
        string[] expectedOperations = { "Add", "Division", "Multiplication", "Pow", "Square", "Subtraction" };

        // Execute actual operation
        var actualOperations = Enum.GetNames(typeof(Operation));

        // Validate response
        Assert.Equal(expectedOperations, actualOperations);
    }

    [Fact]
    public void VerifyEnumValueCount()
    {
        // Define inputs and outputs
        int expectedCount = 6;

        // Execute actual operation
        int actualCount = Enum.GetValues(typeof(Operation)).Length;

        // Validate response
        Assert.Equal(expectedCount, actualCount);
    }

    [Fact]
    public void VerifyParseEnumValue()
    {
        // Define inputs and outputs
        string operationString = "Multiplication";
        Operation expected = Operation.Multiplication;

        // Execute actual operation
        Operation actual = Enum.Parse<Operation>(operationString);

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyToStringEnumValue()
    {
        // Define inputs and outputs
        Operation operation = Operation.Division;
        string expected = "Division";

        // Execute actual operation
        string actual = operation.ToString();

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyInvalidEnumParse()
    {
        // Define inputs and outputs
        string invalidOperation = "InvalidOperation";

        // Execute actual operation and validate response
        Assert.Throws<ArgumentException>(() => Enum.Parse<Operation>(invalidOperation));
    }
}