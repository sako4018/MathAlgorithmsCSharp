namespace MathAlgorithms
{
    /// <summary>
    /// Задача 5: Просто число
    /// Въведи число, провери дали е просто
    /// Пример: 17 → да, 15 → не
    /// </summary>
    public static class PrimeNumber
    {
        public static void Run()
        {
            Console.WriteLine("=== Просто число ===");
            Console.Write("Въведи число: ");
            int n = int.Parse(Console.ReadLine()!);

            if (IsPrime(n))
                Console.WriteLine($"{n} е просто число ✓");
            else
                Console.WriteLine($"{n} НЕ е просто число");
            Console.WriteLine();
        }

        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
