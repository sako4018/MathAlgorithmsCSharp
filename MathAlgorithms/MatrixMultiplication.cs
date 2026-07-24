using System;

namespace MathAlgorithms
{
    /// <summary>
    /// Задача 14: Матрица — умножение
    /// Умножи две матрици
    /// Пример: [1,2] * [5,6] = [19,22]
    ///         [3,4]   [7,8]   [43,50]
    /// </summary>
    public static class MatrixMultiplication
    {
        public static void Run()
        {
            Console.WriteLine("=== Матрица — умножение ===");
            Console.Write("Редове на първата матрица: ");
            int rows1 = int.Parse(Console.ReadLine()!);
            Console.Write("Колони на първата матрица: ");
            int cols1 = int.Parse(Console.ReadLine()!);
            Console.Write("Колони на втората матрица: ");
            int cols2 = int.Parse(Console.ReadLine()!);

            int[,] matrix1 = new int[rows1, cols1];
            int[,] matrix2 = new int[cols1, cols2];

            Console.WriteLine("\nВъведи елементите на първата матрица:");
            for (int i = 0; i < rows1; i++)
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write($"matrix1[{i},{j}] = ");
                    matrix1[i, j] = int.Parse(Console.ReadLine()!);
                }

            Console.WriteLine("\nВъведи елементите на втората матрица:");
            for (int i = 0; i < cols1; i++)
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"matrix2[{i},{j}] = ");
                    matrix2[i, j] = int.Parse(Console.ReadLine()!);
                }

            int[,] result = Multiply(matrix1, matrix2, rows1, cols1, cols2);

            Console.WriteLine("\nРезултат:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                    Console.Write($"{result[i,j],6}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int[,] Multiply(int[,] a, int[,] b, int rows, int common, int cols)
        {
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    for (int k = 0; k < common; k++)
                        result[i, j] += a[i, k] * b[k, j];

            return result;
        }
    }
}
