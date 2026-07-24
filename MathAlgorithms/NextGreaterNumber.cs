using System;

namespace MathAlgorithms
{
    /// <summary>
    /// Задача 17: Следващо по-голямо число със същите цифри
    /// Въведи число, намери най-малкото по-голямо число със същите цифри
    /// Пример: 123 → 132
    /// Пример: 321 → няма
    /// Пример: 1234 → 1243
    /// </summary>
    public static class NextGreaterNumber
    {
        public static void Run()
        {
            Console.WriteLine("=== Следващо по-голямо число ===");
            Console.Write("Въведи число: ");
            int n = int.Parse(Console.ReadLine()!);

            int result = FindNextGreater(n);

            if (result == -1)
                Console.WriteLine($"{n} → няма по-голямо число със същите цифри");
            else
                Console.WriteLine($"{n} → {result}");
            Console.WriteLine();
        }

        private static int FindNextGreater(int n)
        {
            char[] digits = n.ToString().ToCharArray();
            int len = digits.Length;

            // Намираме първата цифра от дясно, която е по-малка от следващата
            int i = len - 2;
            while (i >= 0 && digits[i] >= digits[i + 1])
                i--;

            if (i == -1) return -1; // Няма по-голямо число

            // Намираме най-малката цифра от дясно, която е по-голяма от digits[i]
            int j = len - 1;
            while (digits[j] <= digits[i])
                j--;

            // Разменяме
            char temp = digits[i];
            digits[i] = digits[j];
            digits[j] = temp;

            // Обръщаме частта след i
            Array.Reverse(digits, i + 1, len - i - 1);

            return int.Parse(new string(digits));
        }
    }
}
