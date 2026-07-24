using System;
using System.Collections.Generic;

namespace MathAlgorithms
{
    /// <summary>
    /// Задача 10: Reverse Polish Notation (изчисляване)
    /// Изчисли RPN израз
    /// Пример: "3 4 +" → 7
    /// Пример: "5 1 2 + 4 * + 3 -" → 14
    /// </summary>
    public static class RPNEvaluator
    {
        public static void Run()
        {
            Console.WriteLine("=== Reverse Polish Notation (изчисляване) ===");
            Console.Write("Въведи RPN израз (числа и оператори + - * /): ");
            string expression = Console.ReadLine()!;

            try
            {
                double result = Evaluate(expression);
                Console.WriteLine($"Резултат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
            Console.WriteLine();
        }

        private static double Evaluate(string expression)
        {
            Stack<double> stack = new Stack<double>();
            string[] tokens = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    if (stack.Count < 2)
                        throw new Exception("Невалиден RPN израз");

                    double b = stack.Pop();
                    double a = stack.Pop();

                    switch (token)
                    {
                        case "+": stack.Push(a + b); break;
                        case "-": stack.Push(a - b); break;
                        case "*": stack.Push(a * b); break;
                        case "/":
                            if (b == 0) throw new Exception("Деление на нула!");
                            stack.Push(a / b);
                            break;
                        default:
                            throw new Exception($"Непознат оператор: {token}");
                    }
                }
            }

            if (stack.Count != 1)
                throw new Exception("Невалиден RPN израз");

            return stack.Pop();
        }
    }
}
