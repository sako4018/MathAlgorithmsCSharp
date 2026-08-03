namespace MathAlgorithms
{
    /// <summary>
    /// Задача 7: Перфектно число
    /// Перфектно число = сумата на делителите му (без самото число) = самото число
    /// Пример: 6 → 1+2+3 = 6 ✓
    /// Намира всички перфектни числа до N
    /// </summary>
    public static class PerfectNumber
    {
        public static void Run()
        {
            Console.WriteLine("=== Перфектно число ===");
            Console.Write("Намери перфектни числа до: ");
            int limit = int.Parse(Console.ReadLine()!);

            int[] perfectNumbers = FindPerfectNumbers(limit);

            Console.Write($"Перфектни числа до {limit}: ");
            if (perfectNumbers.Length == 0)
                Console.WriteLine("няма перфектни числа");
            else
                Console.WriteLine(string.Join(" ", perfectNumbers));

            Console.WriteLine($"\nНамерени: {perfectNumbers.Length} перфектни числа");
            Console.WriteLine();
        }

        /// <summary>
        /// Проверява дали числото е перфектно.
        /// Перфектно число = сумата на делителите му (без самото число) = самото число.
        /// </summary>
        public static bool IsPerfectNumber(int n)
        {
            if (n < 2)
                return false;

            int sum = 1;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i != n / i)
                        sum += n / i;
                }
            }

            return sum == n;
        }

        /// <summary>
        /// Намира всички перфектни числа до limit (включително).
        /// </summary>
        public static int[] FindPerfectNumbers(int limit)
        {
            List<int> perfectNumbers = new List<int>();

            for (int n = 2; n <= limit; n++)
            {
                if (IsPerfectNumber(n))
                    perfectNumbers.Add(n);
            }

            return perfectNumbers.ToArray();
        }
    }
}
