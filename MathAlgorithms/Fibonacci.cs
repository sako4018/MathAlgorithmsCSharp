namespace MathAlgorithms
{
    /// <summary>
    /// Задача 2: Фибоначи — извежда първите N числа от редицата
    /// 0, 1, 1, 2, 3, 5, 8, 13, 21, ...
    /// </summary>
    public static class Fibonacci
    {
        public static void Run()
        {
            Console.WriteLine("=== Фибоначи ===");
            Console.Write("Колко числа искаш? ");
            int target = int.Parse(Console.ReadLine()!);

            int one = 0;
            int two = 1;

            Console.Write($"{one} {two} ");

            for (int i = 2; i < target; i++)
            {
                int three = one + two;
                Console.Write($"{three} ");
                one = two;
                two = three;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
