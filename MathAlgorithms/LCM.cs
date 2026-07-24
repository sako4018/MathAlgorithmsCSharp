namespace MathAlgorithms
{
    /// <summary>
    /// Задача 4: НОК (Най-малко общо кратно)
    /// НОК(a, b) = (a * b) / НОД(a, b)
    /// Пример: НОК(12, 18) = 36
    /// </summary>
    public static class LCM
    {
        public static void Run()
        {
            Console.WriteLine("=== НОК (Най-малко общо кратно) ===");
            Console.Write("Първо число: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Второ число: ");
            int b = int.Parse(Console.ReadLine()!);

            int gcd = GCD(a, b);
            int lcm = (a * b) / gcd;

            Console.WriteLine($"НОК({a}, {b}) = {lcm}");
            Console.WriteLine();
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
