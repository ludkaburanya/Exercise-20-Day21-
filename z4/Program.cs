using System;

namespace z4
{
    class Class1
    {
        static void Sin(int x)
        {
            Console.WriteLine($"Выражение равно = {x -Math.Sin(x)}");
            Thread.Sleep(100);

        }
        static void Main()
        {
            Console.Write("Введите число x: ");
            int x = int.Parse(Console.ReadLine());
            Parallel.For(0, 10, Sin);
        }
    }
}