namespace MathAlgorithms
{
    /// <summary>
    /// Задача 1: Извежда квадратите на числата от N до 1
    /// (i * i - 1) за всяко i
    /// </summary>
    public static class Squares
    {
        public static void Run()
        {
            Console.WriteLine("=== Квадрати на числа ===");
            Console.Write("Въведи число N: ");
            int number = int.Parse(Console.ReadLine()!);

            for (int i = number; i >= 1; i--)
            {
                int result = i * i - 1;
                Console.WriteLine($"{i}² - 1 = {result}");
            }
            Console.WriteLine();
        }
    }
}
