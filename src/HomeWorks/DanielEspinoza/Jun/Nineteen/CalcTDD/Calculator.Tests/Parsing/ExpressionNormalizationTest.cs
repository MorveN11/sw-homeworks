using Calculator.Parsing;

namespace Calculator.Tests.Parsing;


public class ExpressionNormalizationTest
{

    public readonly INormalizer _normalizer;

    public ExpressionNormalizationTest()
    {
        _normalizer = new ExpressionNormalizer();
    }

    [Fact]
    public void NormalizeExpressionRemoveSpaces()
    {
        // Arrange
        string expression = "2 + 3 - 4 * 5 / 6";

        // Act
        string normalized = _normalizer.Normalize(expression);

        // Assert
        Assert.DoesNotContain(" ", normalized);
    }

    [Fact]
    public void NormalizeExpressionCorrectDoubleNegatives()
    {
        // Arrange
        string expression = "2 -- 3 * -4";

        // Act
        string normalized = _normalizer.Normalize(expression);

        // Assert
        Assert.Equal("2+3*-4", normalized);
    }

    [Fact]
    public void NormalizeExpressionCorrectMixedOperators()
    {
        // Arrange
        string expression = "2 * -3 + 4 / -5";

        // Act
        string normalized = _normalizer.Normalize(expression);

        // Assert
        Assert.Equal("2*-3+4/-5", normalized);
    }

    [Fact]
    public void NormalizeExpressionHandleMultipleUnaryOperators()
    {
        // Arrange
        string expression = "-2 + --3 * 4 / -5";

        // Act
        string normalized = _normalizer.Normalize(expression);

        // Assert
        Assert.Equal("-2+3*4/-5", normalized);
    }
}
