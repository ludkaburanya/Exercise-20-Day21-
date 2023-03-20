using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = double.Parse(Console.ReadLine());

            Task[] ex1 = new Task[2]
            {
                new Task(() => Console.WriteLine(z11(a,200))),
                new Task(() => Console.WriteLine(z22(a,400)))
            };
            foreach (var t in ex1)
                t.Start();
            Task.WaitAny(ex1);
            Console.WriteLine(new string('-', 30));
            Task.WaitAll(ex1);
            Console.WriteLine(new string('-', 30));

            double z11 (double a, int milliseconds)
            {
                Thread.Sleep(milliseconds);
                Console.WriteLine(Thread.CurrentThread.Name);
                return (Math.Sin((3.14 / 2) + 3 * a)) / (1 - Math.Sin((3 * a - 3.14)));
            }

            double z22(double a, int milliseconds)
            {
                Thread.Sleep(milliseconds);
                Console.WriteLine(Thread.CurrentThread.Name);
                return (Math.Tan((5 / 4) * 3.14) + ((3 / 2) * a));
            }
            Console.WriteLine("Завершение работы приложения.");

            Console.ReadLine();
        }
    }
}