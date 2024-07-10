using Calculator.Operations.Concretes;
using Calculator;

namespace Test;

public class CalculatorTest
{
    [Fact]
    public void VerifyIfANewOperationCanBePerformed()
    {
        // Define inputs
        var calculator = new Calculator.Calculator();
        var customOperation = new Pow();
        var expected = 8;

        // Execute actual operation
        calculator.RegisterOperation(Operation.Pow, customOperation);
        var actual = calculator.PerformOperation(Operation.Pow, 2, 3);

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyIfAOperationThatCalculatorContainsCanBePerformed()
    {
        // Define inputs and outputs
        var calculator = new Calculator.Calculator();
        double number1 = 10;
        double number2 = 5;
        double expected = 15;

        // Execute actual operation
        var actual = calculator.PerformOperation(Operation.Add, number1, number2);

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyIfAnExpressionCanBePerformed()
    {
        // Define inputs and outputs
        var calculator = new Calculator.Calculator();
        var expression = "2+3*4/2";
        var expected = 8;

        // Execute actual operation
        var actual = calculator.PerformExpressionCalculation(expression);

        // Validate response
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void VerifyIfCanNotPerformAnOperationThatWereNotAddedBefore()
    {
        // Define inputs
        var calculator = new Calculator.Calculator();

        // Execute and validate
        Assert.Throws<InvalidOperationException>(() => calculator.PerformOperation(Operation.Pow, 1, 2));
    }

    [Fact]
    public void VerifyPerformExpressionCalculationThrowsException()
    {
        // Define inputs
        var calculator = new Calculator.Calculator();
        string invalidExpression = "2+*3";

        // Execute and validate
        Assert.Throws<InvalidOperationException>(() => calculator.PerformExpressionCalculation(invalidExpression));
    }
}