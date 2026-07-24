using System;

namespace MathAlgorithms
{
    /// <summary>
    /// Задача 12: Квадратно уравнение — цели корени
    /// Въведи a, b, c. Намери корените на ax² + bx + c = 0
    /// Пример: x² + 1 = 0 → няма реални решения
    /// </summary>
    public static class QuadraticEquation
    {
        public static void Run()
        {
            Console.WriteLine("=== Квадратно уравнение (ax² + bx + c = 0) ===");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine()!);

            if (a == 0)
            {
                Console.WriteLine("a не може да бъде 0 (не е квадратно уравнение)");
                return;
            }

            double discriminant = b * b - 4 * a * c;

            Console.WriteLine($"\nДискриминант: D = {b}² - 4·{a}·{c} = {discriminant}");

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"D > 0 → два корена:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"D = 0 → един корен:");
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine($"D < 0 → няма реални корени!");
            }
            Console.WriteLine();
        }
    }
}
