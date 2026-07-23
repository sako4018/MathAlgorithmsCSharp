namespace MathAlgorithms
{
    /// <summary>
    /// Задача 4: НОД (Най-голям общ делител) — Алгоритъм на Евклид
    /// Намира НОД на две числа чрез последователно деление
    /// </summary>
    public static class GCD
    {
        public static void Run()
        {
            Console.WriteLine("=== НОД (Алгоритъм на Евклид) ===");
            Console.Write("Първо число: ");
            int firstNum = int.Parse(Console.ReadLine()!);
            Console.Write("Второ число: ");
            int secNum = int.Parse(Console.ReadLine()!);

            // Запазваме оригиналните стойности за принтиране
            int originalFirst = firstNum;
            int originalSecond = secNum;

            while (secNum != 0)
            {
                int temp = secNum;
                secNum = firstNum % secNum;
                firstNum = temp;
            }

            Console.WriteLine($"НОД({originalFirst}, {originalSecond}) = {firstNum}");
            Console.WriteLine();
        }
    }
}
