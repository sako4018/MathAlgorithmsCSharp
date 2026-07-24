using System;
using System.Collections.Generic;

namespace MathAlgorithms
{
    /// <summary>
    /// Задача 13: Големи числа — факториел
    /// Изчисли N! (за големи числа като 100!)
    /// Подсказка: ползвай масив от цифри
    /// </summary>
    public static class BigNumberFactorial
    {
        public static void Run()
        {
            Console.WriteLine("=== Големи числа — факториел ===");
            Console.Write("Въведи N (до 500): ");
            int n = int.Parse(Console.ReadLine()!);

            if (n < 0)
            {
                Console.WriteLine("Невалидно число!");
                return;
            }

            string result = Factorial(n);
            Console.WriteLine($"{n}! = {result}");
            Console.WriteLine($"Дължина: {result.Length} цифри");
            Console.WriteLine();
        }

        private static string Factorial(int n)
        {
            List<int> digits = new List<int> { 1 };

            for (int i = 2; i <= n; i++)
            {
                int carry = 0;
                for (int j = 0; j < digits.Count; j++)
                {
                    int product = digits[j] * i + carry;
                    digits[j] = product % 10;
                    carry = product / 10;
                }

                while (carry > 0)
                {
                    digits.Add(carry % 10);
                    carry /= 10;
                }
            }

            digits.Reverse();
            return string.Join("", digits);
        }
    }
}
