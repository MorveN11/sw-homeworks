using System.Globalization;
using Calculator.Expressions;

namespace Calculator.Parser;

    public class ExprParser
    {
        private readonly string _input;
        private int _pos;

        public ExprParser(string input)
        {
            _input = input;
            _pos = 0;
        }

        public Expr Parse()
        {
            if(_input.Length == 0){
                throw new Exception("Empty Expression");
            }
            Expr expr = ParseExpression();
            if (_pos < _input.Length)
            {
                throw new Exception("Invalid Expression");
            }
            return expr;
        }

        private Expr ParseExpression()
        {
            Expr expr = ParseTerm();

            while (_pos < _input.Length && (_input[_pos] == '+' || _input[_pos] == '-'))
            {
                char op = _input[_pos];
                _pos++;
                Expr right = ParseTerm();
                expr = op switch
                {
                    '+' => new Addition(expr, right),
                    '-' => new Subtraction(expr, right),
                    _ => throw new InvalidOperationException("Unknown Operator"),
                };
            }

            return expr;
        }

        private Expr ParseTerm()
        {
            Expr expr = ParseFactor();

            while (_pos < _input.Length && (_input[_pos] == '*' || _input[_pos] == '/' || _input[_pos] == '%'))
            {
                char op = _input[_pos];
                _pos++;
                Expr right = ParseFactor();
                expr = op switch
                {
                    '*' => new Multiplication(expr, right),
                    '/' => new Division(expr, right),
                    '%' => new Mod(expr, right),
                    _ => throw new InvalidOperationException("Unknown Operator"),
                };
            }

            return expr;
        }

        private Expr ParseFactor()
        {
            Expr expr = ParsePrimary();

            while (_pos < _input.Length && _input[_pos] == '^')
            {
                char op = _input[_pos];
                _pos++;
                Expr right = ParsePrimary();
                expr = new Exponentiation(expr, right);
            }

            return expr;
        }

        private Expr ParsePrimary()
        {
            if (_pos < _input.Length && (_input[_pos] == '+' || _input[_pos] == '-'))
            {
                char op = _input[_pos];
                _pos++;
                Expr right = ParsePrimary();
                return op switch
                {
                    '-' => new Negation(right),
                    _ => throw new InvalidOperationException("Unknown Operator"),
                };
            }

            if (_pos < _input.Length && _input[_pos] == '(')
            {
                _pos++;
                Expr expr = ParseExpression();
                if (_pos >= _input.Length || _input[_pos] != ')')
                {
                    throw new Exception("Fatal Unclosed Parenthesis");
                }
                _pos++;
                return expr;
            }

            return ParseNumber();
        }

        private Expr ParseNumber()
        {
            int start = _pos;
            while (_pos < _input.Length && (char.IsDigit(_input[_pos]) || _input[_pos] == '.'))
            {
                _pos++;
            }

            if (start == _pos)
            {
                throw new Exception($"Number expected at {_pos} position");
            }

            string number = _input.Substring(start, _pos - start);
            if (double.TryParse(number, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
            {
                return new Number(result);
            }

            throw new Exception("Invalid Number");
        }
    }
