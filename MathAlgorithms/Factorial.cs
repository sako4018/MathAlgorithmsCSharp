namespace MathAlgorithms
{
    /// <summary>
    /// Задача 1: Факториел
    /// Въведи N, изведи N!
    /// Пример: 5 → 120
    /// </summary>
    public static class Factorial
    {
        public static void Run()
        {
            Console.WriteLine("=== Факториел ===");
            Console.Write("Въведи число N: ");
            int n = int.Parse(Console.ReadLine()!);

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine($"{n}! = {result}");
            Console.WriteLine();
        }
    }
}
