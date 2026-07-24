namespace MathAlgorithms
{
    /// <summary>
    /// Задача 8: Конвертиране на бройни системи
    /// Въведи число и целева бройна система (2, 8, 16)
    /// Пример: 255, base=16 → FF
    /// Пример: 42, base=2 → 101010
    /// </summary>
    public static class NumberBaseConversion
    {
        public static void Run()
        {
            Console.WriteLine("=== Конвертиране на бройни системи ===");
            Console.Write("Въведи число (десетично): ");
            int number = int.Parse(Console.ReadLine()!);
            Console.Write("Целева бройна система (2, 8 или 16): ");
            int baseNum = int.Parse(Console.ReadLine()!);

            if (baseNum != 2 && baseNum != 8 && baseNum != 16)
            {
                Console.WriteLine("Невалидна бройна система! Ползвай 2, 8 или 16.");
                return;
            }

            string result = ConvertToBase(number, baseNum);
            Console.WriteLine($"{number} (10) = {result} ({baseNum})");
            Console.WriteLine();
        }

        private static string ConvertToBase(int number, int baseNum)
        {
            if (number == 0) return "0";

            string digits = "0123456789ABCDEF";
            string result = "";
            bool negative = number < 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                result = digits[number % baseNum] + result;
                number /= baseNum;
            }

            return negative ? "-" + result : result;
        }
    }
}
