namespace MathAlgorithms
{
    /// <summary>
    /// Задача 16: Power of Two
    /// Провери дали дадено число е степен на 2
    /// Пример: 8 → да (2³), 6 → не
    /// Подсказка: побитова операция
    /// </summary>
    public static class PowerOfTwo
    {
        public static void Run()
        {
            Console.WriteLine("=== Power of Two ===");
            Console.Write("Въведи число: ");
            int n = int.Parse(Console.ReadLine()!);

            if (IsPowerOfTwo(n))
                Console.WriteLine($"{n} е степен на 2 ✓");
            else
                Console.WriteLine($"{n} НЕ е степен на 2");
            Console.WriteLine();
        }

        private static bool IsPowerOfTwo(int n)
        {
            // Побитова операция: n & (n-1) == 0 за степени на 2
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
