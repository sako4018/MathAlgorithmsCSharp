using System;

namespace MathAlgorithms
{
    /// <summary>
    /// Задача 15: Генеричен стек
    /// Напиши собствен Generic Stack<T>
    /// Методи: Push, Pop, Peek, Count, IsEmpty
    /// Без да ползваш System.Collections.Generic.Stack
    /// </summary>
    public static class GenericStack
    {
        public static void Run()
        {
            Console.WriteLine("=== Генеричен стек (демо) ===");
            MyStack<int> stack = new MyStack<int>();

            Console.WriteLine("Push: 10, 20, 30");
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Count: {stack.Count}");
            Console.WriteLine($"IsEmpty: {stack.IsEmpty}");

            Console.WriteLine($"\nPop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Count след 2 Pop: {stack.Count}");

            Console.WriteLine($"\nPop: {stack.Pop()}");
            Console.WriteLine($"IsEmpty: {stack.IsEmpty}");
            Console.WriteLine();
        }
    }

    public class MyStack<T>
    {
        private T[] items;
        private int top;
        private const int DefaultCapacity = 4;

        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public MyStack()
        {
            items = new T[DefaultCapacity];
            top = -1;
            Count = 0;
        }

        public void Push(T item)
        {
            if (Count == items.Length)
                Array.Resize(ref items, items.Length * 2);

            top++;
            items[top] = item;
            Count++;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стекът е празен!");

            T item = items[top];
            top--;
            Count--;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стекът е празен!");

            return items[top];
        }
    }
}
