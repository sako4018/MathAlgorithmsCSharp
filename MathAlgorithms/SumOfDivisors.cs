namespace MathAlgorithms
{
    /// <summary>
    /// Задача 6: Събиране на делители
    /// Въведи число, намери сумата на всички негови делители
    /// Пример: 12 → 1+2+3+4+6+12 = 28
    /// </summary>
    public static class SumOfDivisors
    {
        public static void Run()
        {
            Console.WriteLine("=== Събиране на делители ===");
            Console.Write("Въведи число: ");
            int n = int.Parse(Console.ReadLine()!);

            int sum = 0;
            string divisors = "";

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (divisors.Length > 0) divisors += "+";
                    divisors += i;
                }
            }

            Console.WriteLine($"Делители на {n}: {divisors} = {sum}");
            Console.WriteLine();
        }
    }
}
