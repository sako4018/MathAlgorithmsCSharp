namespace MathAlgorithms
{
    /// <summary>
    /// Задача 3: Палиндром
    /// Въведи число, провери дали е палиндром
    /// Пример: 121 → да, 123 → не
    /// </summary>
    public static class Palindrome
    {
        public static void Run()
        {
            Console.WriteLine("=== Палиндром ===");
            Console.Write("Въведи число: ");
            int number = int.Parse(Console.ReadLine()!);

            int original = number;
            int reversed = 0;

            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            if (original == reversed)
                Console.WriteLine($"{original} е палиндром ✓");
            else
                Console.WriteLine($"{original} НЕ е палиндром");
            Console.WriteLine();
        }
    }
}
