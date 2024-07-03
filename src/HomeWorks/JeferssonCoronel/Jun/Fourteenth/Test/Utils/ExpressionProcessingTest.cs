using Calculator.Utils;

namespace Test.Utils;

public class ExpressionProcessingTest
{
    [Fact]
    public void VerifyThatReturnsCorrectOperandsForValidOperation()
    {
        // Define inputs and outputs
        var operation = "2+3/1";
        var expected = new List<int> { 3, 1, 2 };

        // Execute actual operation
        var expressionEvaluator = new ExpressionEvaluator();
        var expressionProcessing = new ExpressionProcessing();
        var expressionEvaluated = expressionEvaluator.GetEvaluatedExpression(operation);
        var expressionProcessed = expressionProcessing.GetOperationsDividedInOperatorsAndOperands(
            expressionEvaluated);

        var actual = expressionProcessed.operands;

        // Validate response
        MyExtensions.AssertList(expected, actual);
    }

    [Fact]
    public void VerifyThatReturnsCorrectOperatorsForValidOperation()
    {
        // Define inputs and outputs
        var operation = "9+5/2";
        var expected = new List<Operation> { Operation.Division, Operation.Add };

        // Execute actual operation
        var expressionEvaluator = new ExpressionEvaluator();
        var expressionProcessing = new ExpressionProcessing();
        var expressionEvaluated = expressionEvaluator.GetEvaluatedExpression(operation);
        var expressionProcessed = expressionProcessing.GetOperationsDividedInOperatorsAndOperands(
            expressionEvaluated);

        var actual = expressionProcessed.operators;

        // Validate response
        MyExtensions.AssertList(expected, actual);
    }

    [Fact]
    public void VerifyThatReturnsEmptyListsForEmptyOperation()
    {
        // Define inputs and outputs
        var operation = "";
        var expectedOperators = new List<Operation>();
        var expectedOperands = new List<int>();

        // Execute actual operation
        var expressionEvaluator = new ExpressionEvaluator();
        var expressionProcessing = new ExpressionProcessing();
        var expressionEvaluated = expressionEvaluator.GetEvaluatedExpression(operation);
        var expressionProcessed = expressionProcessing.GetOperationsDividedInOperatorsAndOperands(expressionEvaluated);

        var actualOperators = expressionProcessed.operators;
        var actualOperands = expressionProcessed.operands;

        // Validate response
        MyExtensions.AssertList(expectedOperators, actualOperators);
        MyExtensions.AssertList(expectedOperands, actualOperands);
    }

    [Fact]
    public void VerifyThatReturnsCorrectOperandsForSingleDigitOperation()
    {
        // Define inputs and outputs
        var operation = "5+3";
        var expected = new List<int> { 5, 3 };

        // Execute actual operation
        var expressionEvaluator = new ExpressionEvaluator();
        var expressionProcessing = new ExpressionProcessing();
        var expressionEvaluated = expressionEvaluator.GetEvaluatedExpression(operation);
        var expressionProcessed = expressionProcessing.GetOperationsDividedInOperatorsAndOperands(expressionEvaluated);

        var actual = expressionProcessed.operands;

        // Validate response
        MyExtensions.AssertList(expected, actual);
    }

    [Fact]
    public void VerifyThatReturnsCorrectOperatorsForSingleDigitOperation()
    {
        // Define inputs and outputs
        var operation = "7*4";
        var expected = new List<Operation> { Operation.Multiplication };

        // Execute actual operation
        var expressionEvaluator = new ExpressionEvaluator();
        var expressionProcessing = new ExpressionProcessing();
        var expressionEvaluated = expressionEvaluator.GetEvaluatedExpression(operation);
        var expressionProcessed = expressionProcessing.GetOperationsDividedInOperatorsAndOperands(expressionEvaluated);

        var actual = expressionProcessed.operators;

        // Validate response
        MyExtensions.AssertList(expected, actual);
    }

    [Fact]
    public void VerifyThatReturnsCorrectOperandsForComplexOperation()
    {
        // Define inputs and outputs
        var operation = "6/2+5*3";
        var expected = new List<int> { 6, 2, 5, 3 };

        // Execute actual operation
        var expressionEvaluator = new ExpressionEvaluator();
        var expressionProcessing = new ExpressionProcessing();
        var expressionEvaluated = expressionEvaluator.GetEvaluatedExpression(operation);
        var expressionProcessed = expressionProcessing.GetOperationsDividedInOperatorsAndOperands(expressionEvaluated);

        var actual = expressionProcessed.operands;

        // Validate response
        MyExtensions.AssertList(expected, actual);
    }

    [Fact]
    public void VerifyThatReturnsCorrectOperatorsForComplexOperation()
    {
        // Define inputs and outputs
        var operation = "8/4-2^3";
        var expected = new List<Operation> { Operation.Pow, Operation.Division, Operation.Subtraction };

        // Execute actual operation
        var expressionEvaluator = new ExpressionEvaluator();
        var expressionProcessing = new ExpressionProcessing();
        var expressionEvaluated = expressionEvaluator.GetEvaluatedExpression(operation);
        var expressionProcessed = expressionProcessing.GetOperationsDividedInOperatorsAndOperands(expressionEvaluated);

        var actual = expressionProcessed.operators;

        // Validate response
        MyExtensions.AssertList(expected, actual);
    }
}