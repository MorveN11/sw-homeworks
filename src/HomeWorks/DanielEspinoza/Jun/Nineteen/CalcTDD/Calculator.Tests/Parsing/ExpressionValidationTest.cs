using Calculator.Parsing;

namespace Calculator.Tests.Expressions;

  public class ExpressionValidatorTests
    {
        private readonly ExpressionValidator _validator;

        public ExpressionValidatorTests()
        {
            _validator = new ExpressionValidator();
        }

        [Theory]
        [InlineData("4^3^2%2%5", true)]
        [InlineData("3 + 5", true)]
        [InlineData("3-5", true)]
        [InlineData("3 * 5", true)]
        [InlineData("3 / 5", true)]
        [InlineData("3 % 5", true)]
        [InlineData("3 ^ 5", true)]
        [InlineData("-3 + 5", true)]
        [InlineData("3 + -5", true)]
        [InlineData("3 + 5 - 2 * 4 / 2 ^ 3 % 2", true)]
        [InlineData("3 + * 5", false)]
        [InlineData("3 ++ 5", true)]
        [InlineData("3 -- 5", true)]
        [InlineData("3 ** 5", false)]
        [InlineData("3 // 5", false)]
        [InlineData("3 %% 5", false)]
        [InlineData("3 ^^ 5", false)]
        [InlineData("3 + 5 5", false)]
        [InlineData("3 5 + 5", false)]
        [InlineData(" 3 + 5 ", true)]
        [InlineData("3+5", true)]
        [InlineData("  3+5  ", true)]
        [InlineData("3 + -5 * -2", true)]
        [InlineData("", false)]
        [InlineData("   ", false)]
        public void Validate_VariousExpressions_ReturnsExpectedResults(string expression, bool expected)
        {
            // Act
            var result = _validator.Validate(expression);

            // Assert
            Assert.Equal(expected, result);
        }
    }
