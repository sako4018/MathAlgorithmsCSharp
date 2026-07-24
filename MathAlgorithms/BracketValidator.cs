using System.Collections.Generic;

namespace MathAlgorithms
{
    /// <summary>
    /// Задача 9: Стек — валиден ли е изразът?
    /// Пример: "(1+2*(3)" → не
    /// Пример: "{[()]}" → да
    /// </summary>
    public static class BracketValidator
    {
        public static void Run()
        {
            Console.WriteLine("=== Валидиране на скоби ===");
            Console.Write("Въведи израз: ");
            string expression = Console.ReadLine()!;

            if (IsValid(expression))
                Console.WriteLine("Изразът е валиден ✓");
            else
                Console.WriteLine("Изразът НЕ е валиден");
            Console.WriteLine();
        }

        private static bool IsValid(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
