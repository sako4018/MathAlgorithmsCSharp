namespace MathAlgorithms
{
    /// <summary>
    /// Задача 18: Кръг от числа (Задачата на Йосиф)
    /// N души стоят в кръг. Всеки k-ти отпада.
    /// Кой е последният оцелял?
    /// Пример: N=7, k=3 → 4
    /// </summary>
    public static class JosephusProblem
    {
        public static void Run()
        {
            Console.WriteLine("=== Задачата на Йосиф ===");
            Console.Write("Брой хора (N): ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Всеки k-ти отпада: ");
            int k = int.Parse(Console.ReadLine()!);

            int survivor = FindSurvivor(n, k);
            Console.WriteLine($"\nПоследният оцелял е човек #{survivor}");
            Console.WriteLine();
        }

        private static int FindSurvivor(int n, int k)
        {
            int survivor = 0;
            for (int i = 2; i <= n; i++)
            {
                survivor = (survivor + k) % i;
            }
            return survivor + 1; // 1-based index
        }
    }
}
