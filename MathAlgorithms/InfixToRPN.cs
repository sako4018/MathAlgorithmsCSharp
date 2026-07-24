using System;
using System.Collections.Generic;

namespace MathAlgorithms
{
    /// <summary>
    /// Задача 11: Reverse Polish Notation (конвертиране)
    /// Конвертирай инфиксен израз в RPN
    /// Пример: "(3 + 4) * 5" → "3 4 + 5 *"
    /// </summary>
    public static class InfixToRPN
    {
        public static void Run()
        {
            Console.WriteLine("=== Конвертиране в RPN ===");
            Console.Write("Въведи инфиксен израз: ");
            string expression = Console.ReadLine()!;

            string rpn = ConvertToRPN(expression);
            Console.WriteLine($"RPN: {rpn}");
            Console.WriteLine();
        }

        private static string ConvertToRPN(string expression)
        {
            string result = "";
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += " " + stack.Pop();
                    }
                    if (stack.Count > 0) stack.Pop(); // Remove '('
                }
                else if (IsOperator(c))
                {
                    result += " ";
                    while (stack.Count > 0 && Precedence(stack.Peek()) >= Precedence(c))
                    {
                        result += stack.Pop() + " ";
                    }
                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                result += " " + stack.Pop();
            }

            return result.Trim();
        }

        private static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private static int Precedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-': return 1;
                case '*':
                case '/': return 2;
                default: return 0;
            }
        }
    }
}
