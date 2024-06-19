using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Calculator.Operations.Concretes;
using Calculator.Operations.Interfaces;

namespace Calculator
{
    public class Calculator
    {
        private byte Precedence(char operation)
        {
            byte precedence = 0;
            switch (operation)
            {
                case '+':
                    precedence = 4;
                    break;
                case '-':
                    precedence = 5;
                    break;
                case '*':
                    precedence = 2;
                    break;
                case '/':
                    precedence = 3;
                    break;
                case '^':
                    precedence = 1;
                    break;
                case 'r':
                    precedence = 0;
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }
            return precedence;
        }

        private List<string> CreateOperation(string operation)
        {
            List<string> tokens = new List<string>();
            Regex regex = new Regex(@"(?<!\d)-?\d+(\.\d+)?|[+\-*/^r]");
            MatchCollection matches = regex.Matches(operation);
            foreach (Match match in matches)
            {
                tokens.Add(match.Value);
            }
            return tokens;
        }

        private Dictionary<char, IOperation> GetOperations()
        {
            return new Dictionary<char, IOperation>()
            {
                {'r', new SquareRoot()},
                {'^', new Pow()},
                {'*', new Multiplication()},
                {'/', new Division()},
                {'+', new Addition()},
                {'-', new Substraction()}
            };
        }

        private List<string> ConvertToPostfix(List<string> operations)
        {
            Stack<char> stack = new Stack<char>();
            List<string> output = new List<string>();

            foreach (string token in operations)
            {
                if (double.TryParse(token, out _))
                {
                    output.Add(token);
                }
                else
                {
                    char op = token[0];
                    while (stack.Count > 0 && Precedence(stack.Peek()) <= Precedence(op))
                    {
                        output.Add(stack.Pop().ToString());
                    }
                    stack.Push(op);
                }
            }

            while (stack.Count > 0)
            {
                output.Add(stack.Pop().ToString());
            }

            return output;
        }

        private double EvaluatePostfix(List<string> postfix)
        {
            Stack<double> stack = new Stack<double>();
            var operations = GetOperations();

            foreach (string token in postfix)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    char op = token[0];
                    IOperation operation = operations[op];

                    if (operation is IOperationOneValue operationOneValue)
                    {
                        double value = stack.Pop();
                        stack.Push(operationOneValue.Operation(value));
                    }
                    else if (operation is IOperationWithNValues operationNValues)
                    {
                        double value2 = stack.Pop();
                        double value1 = stack.Pop();
                        stack.Push(operationNValues.Operation(value1, value2));
                    }
                }
            }

            return stack.Pop();
        }

        public string Execute(string operation)
        {
            List<string> operations = CreateOperation(operation);
            List<string> postfix = ConvertToPostfix(operations);
            double result = EvaluatePostfix(postfix);
            return result.ToString();
        }
    }
}
