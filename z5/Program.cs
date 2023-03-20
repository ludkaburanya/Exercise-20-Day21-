namespace z5
{
    class Program
    {
        static void Main()
        {
            void Sum(int n, ParallelLoopState pls)
            {
                int result = 0;
                for (int i = 0; i <= n; i++)
                {
                    if (result >= 10)

                    {
                        Console.WriteLine($"Сумма = {result}");
                        pls.Break();
                        break;
                    }
                    result += i;
                }

            }
            void Mul(int n, ParallelLoopState pls)
            {
                int result = 1;
                for (int i = 1; i < n; i++)
                {
                    if (result >= 10)
                    {
                        Console.WriteLine($"Произведение = {result}");
                        pls.Break();
                        break;
                    }
                    result *= i;
                }
            }

            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 5, 8, 40, 70 }, Sum);
            ParallelLoopResult result2 = Parallel.ForEach<int>(new List<int>() { 1, 5, 8, 40, 70 }, Mul);
            if (!result.IsCompleted)
                Console.WriteLine($"Выполнение цикла завершено на итерации {result.LowestBreakIteration}");

        }
    }
}