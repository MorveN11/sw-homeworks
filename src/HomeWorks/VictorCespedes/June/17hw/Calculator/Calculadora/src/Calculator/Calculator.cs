using Calculadora.src.Operations.Interfaces;
using Calculadora.src.Operations.Clases;
using System;
using System.Collections.Generic;

namespace Calculadora.src.Calculator
{
    public class Calculator : ICalculator
    {
        private Dictionary<char, IComplexOperation> operations;
        private Dictionary<char, ISimpleOperation> simpleOperations;
        private Dictionary<char, int> precedence;

        public Calculator()
        {
            operations = new Dictionary<char, IComplexOperation>
            {
                { '+', new Addition() },
                { '-', new Substraction() },
                { '*', new Multiplication() },
                { '/', new Division() },
                { '^', new Pow() }
            };

            simpleOperations = new Dictionary<char, ISimpleOperation>
            {
                { '√', new SquareRoot() }
            };

            precedence = new Dictionary<char, int>
            {
                { '√', 0 },
                { '^', 1 },
                { '*', 2 },
                { '/', 3 },
                { '+', 4 },
                { '-', 5 }
            };
        }

        public string stringFormater(string expression)
{
    List<char> operands = new List<char>();
    List<char> operators = new List<char>();

    // Separar operadores y operandos
    foreach (char c in expression)
    {
        if (char.IsDigit(c))
        {
            operands.Add(c);
        }
        else if (operations.ContainsKey(c) || simpleOperations.ContainsKey(c))
        {
            operators.Add(c);
        }
    }

    // Ordenar los operadores según su precedencia
    operators.Sort((a, b) => precedence[a] - precedence[b]);

    // Crear la cadena resultante con operadores ordenados por precedencia
    List<char> outputOperators = new List<char>(operators);

    // Crear una lista para los operandos ordenados según la precedencia de los operadores
    List<char> orderedOperands = new List<char>();
    HashSet<int> usedIndexes = new HashSet<int>();

    foreach (char op in operators)
    {
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == op)
            {
                // Operando izquierdo del operador
                if (i > 0 && char.IsDigit(expression[i - 1]) && !usedIndexes.Contains(i - 1))
                {
                    orderedOperands.Add(expression[i - 1]);
                    usedIndexes.Add(i - 1);
                }

                // Operando derecho del operador
                if (i < expression.Length - 1 && char.IsDigit(expression[i + 1]) && !usedIndexes.Contains(i + 1))
                {
                    orderedOperands.Add(expression[i + 1]);
                    usedIndexes.Add(i + 1);
                }
            }
        }
    }

    // Añadir los operandos restantes
    for (int i = 0; i < expression.Length; i++)
    {
        if (char.IsDigit(expression[i]) && !usedIndexes.Contains(i))
        {
            orderedOperands.Add(expression[i]);
        }
    }

    // Combinar operadores y operandos
    List<char> result = new List<char>(outputOperators);
    result.AddRange(orderedOperands);

    return new string(result.ToArray());
}







        public double calculate(string expression)
        {
            // Convertir la expresión a notación postfija (RPN)
            string rpn = ToRPN(expression);

            // Evaluar la expresión en notación postfija
            return EvaluateRPN(rpn);
        }

        private string ToRPN(string expression)
        {
            Stack<char> stack = new Stack<char>();
            Queue<string> output = new Queue<string>();
            int i = 0;

            while (i < expression.Length)
            {
                if (char.IsDigit(expression[i]))
                {
                    string number = string.Empty;
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        number += expression[i];
                        i++;
                    }
                    output.Enqueue(number);
                }
                else if (operations.ContainsKey(expression[i]) || simpleOperations.ContainsKey(expression[i]))
                {
                    char op = expression[i];
                    while (stack.Count > 0 && precedence.ContainsKey(stack.Peek()) && precedence[stack.Peek()] <= precedence[op])
                    {
                        output.Enqueue(stack.Pop().ToString());
                    }
                    stack.Push(op);
                    i++;
                }
                else
                {
                    throw new ArgumentException("Invalid character in expression");
                }
            }

            while (stack.Count > 0)
            {
                output.Enqueue(stack.Pop().ToString());
            }

            return string.Join(" ", output);
        }

        private double EvaluateRPN(string rpn)
        {
            Stack<double> stack = new Stack<double>();
            string[] tokens = rpn.Split(' ');

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else if (operations.ContainsKey(token[0]))
                {
                    double b = stack.Pop();
                    double a = stack.Pop();
                    stack.Push(operations[token[0]].Operation(a, b));
                }
                else if (simpleOperations.ContainsKey(token[0]))
                {
                    double a = stack.Pop();
                    stack.Push(simpleOperations[token[0]].Operation(a));
                }
                else
                {
                    throw new ArgumentException("Invalid token in RPN expression");
                }
            }

            return stack.Pop();
        }
    }
}
