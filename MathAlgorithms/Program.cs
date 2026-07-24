namespace MathAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Избери задача:");
                Console.WriteLine("1. Квадрати на числа");
                Console.WriteLine("2. Фибоначи");
                Console.WriteLine("3. НОД (Алгоритъм на Евклид)");
                Console.WriteLine("4. Факториел");
                Console.WriteLine("5. Палиндром");
                Console.WriteLine("6. НОК (Най-малко общо кратно)");
                Console.WriteLine("7. Просто число");
                Console.WriteLine("8. Събиране на делители");
                Console.WriteLine("9. Перфектно число");
                Console.WriteLine("10. Конвертиране на бройни системи");
                Console.WriteLine("11. Валидиране на скоби");
                Console.WriteLine("12. RPN изчисляване");
                Console.WriteLine("13. Конвертиране в RPN");
                Console.WriteLine("14. Квадратно уравнение");
                Console.WriteLine("15. Големи числа факториел");
                Console.WriteLine("16. Матрица умножение");
                Console.WriteLine("17. Генеричен стек");
                Console.WriteLine("18. Power of Two");
                Console.WriteLine("0. Изход");
                Console.Write("Твой избор: ");

                string choice = Console.ReadLine()!;
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Squares.Run();
                        break;
                    case "2":
                        Fibonacci.Run();
                        break;
                    case "3":
                        GCD.Run();
                        break;
                    case "4":
                        Factorial.Run();
                        break;
                    case "5":
                        Palindrome.Run();
                        break;
                    case "6":
                        LCM.Run();
                        break;
                    case "7":
                        PrimeNumber.Run();
                        break;
                    case "8":
                        SumOfDivisors.Run();
                        break;
                    case "9":
                        PerfectNumber.Run();
                        break;
                    case "10":
                        NumberBaseConversion.Run();
                        break;
                    case "11":
                        BracketValidator.Run();
                        break;
                    case "12":
                        RPNEvaluator.Run();
                        break;
                    case "13":
                        InfixToRPN.Run();
                        break;
                    case "14":
                        QuadraticEquation.Run();
                        break;
                    case "15":
                        BigNumberFactorial.Run();
                        break;
                    case "16":
                        MatrixMultiplication.Run();
                        break;
                    case "17":
                        GenericStack.Run();
                        break;
                    case "18":
                        PowerOfTwo.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Невалиден избор!\n");
                        break;
                }
            }
        }
    }
}
