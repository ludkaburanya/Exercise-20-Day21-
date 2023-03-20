using System.Collections.Specialized;

namespace z3
{
    class Program
    {
        static int Num(int number)
        {
            int dozens, dozens2, units;

            int firstDigit = (int)(number / Math.Pow(10, (int)Math.Log10(number)));
            int lastDigit = (int)(number % 10);

            dozens = 1;
          
                //hundreds = number / 100;
                //hundreds2 = number % 100;
                dozens = number / 10;
                dozens2 = number % 10;
                units = dozens2 % 10;
                Console.WriteLine($"1 NUM {firstDigit}");
                Console.WriteLine($"2 NUM {units}");
            
                
            return firstDigit;
            return lastDigit;
            
            
        }

        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Task<int> task1 = new Task<int>(() => Num(n));
            Task task2 = task1.ContinueWith(task => Print(task.Result));
            Task task3 = task1.ContinueWith(task => Print2(task.Result));
            task1.Start();
            task2.Wait();

        }

        static void Print(int num1)
        {
            Console.WriteLine("");
            
        }
        static void Print2(int num2)
        {
            Console.WriteLine("");
            
        }

    }
}