using Calculator.Expressions;
using Calculator.Parser;

namespace Calc.Tests
{
    public class ParserTests
    {
        [Fact]
        public void ParseValidExpression()
        {
            string input = "2+3*(4-1)";
            ExprParser parser = new ExprParser(input);

            Expr expression = parser.Parse();

            Assert.IsType<Addition>(expression);
            BinaryOperation binaryOp = (BinaryOperation)expression;
            Assert.IsType<Number>(binaryOp.Left);
            Assert.Equal(2, ((Number)binaryOp.Left).Value);
            Assert.Equal('+', binaryOp.Operator);
            Assert.IsType<Multiplication>(binaryOp.Right);
            BinaryOperation nestedBinaryOp = (BinaryOperation)binaryOp.Right;
            Assert.IsType<Number>(nestedBinaryOp.Left);
            Assert.Equal(3, ((Number)nestedBinaryOp.Left).Value);
            Assert.Equal('*', nestedBinaryOp.Operator);
            Assert.IsType<Subtraction>(nestedBinaryOp.Right);
            BinaryOperation nestedNestedBinaryOp = (BinaryOperation)nestedBinaryOp.Right;
            Assert.IsType<Number>(nestedNestedBinaryOp.Left);
            Assert.Equal(4, ((Number)nestedNestedBinaryOp.Left).Value);
            Assert.Equal('-', nestedNestedBinaryOp.Operator);
            Assert.IsType<Number>(nestedNestedBinaryOp.Right);
            Assert.Equal(1, ((Number)nestedNestedBinaryOp.Right).Value);
        }
        [Fact]
        public void ParseInvalidExpression()
        {
            string input = "2+*3";
            ExprParser parser = new ExprParser(input);

            Exception ex = Assert.Throws<Exception>(() => parser.Parse());
            Assert.Equal("Number expected at 2 position", ex.Message);
        }

        [Fact]
        public void ParseMissingParenthesis()
        {
            string input = "2+(3*4";
            ExprParser parser = new ExprParser(input);

            Exception ex = Assert.Throws<Exception>(() => parser.Parse());
            Assert.Equal("Fatal Unclosed Parenthesis", ex.Message);
        }

        [Fact]
        public void ParseEmptyInput()
        {
            string input = "";
            ExprParser parser = new ExprParser(input);

            Exception ex = Assert.Throws<Exception>(() => parser.Parse());
            Assert.Equal("Empty Expression", ex.Message);
        }
    }
}
