namespace z1
{
    class Program
    {
        
        static void MyTask()
        {
            Console.WriteLine("MyTask() запущен.");

            int x = 6478;
            int sum = 0;

            int aTemp = x;
            while (aTemp > 0)
            {
                int digit = aTemp % 10;
                sum += digit;

                aTemp /= 10;
                Thread.Sleep(50);
            }
            Console.WriteLine("Сумма цифр числа 6478: " + sum);
        }
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            Task task = new Task(MyTask);

            // Запустить задачу
            task.Start();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("");
                Thread.Sleep(10);
            }

            Console.WriteLine("Основной поток завершен.");

            Console.WriteLine(new string('-', 25));

            Task task2 = Task.Factory.StartNew((MyTask));
            {
                Console.WriteLine("Первый поток запущен.");
            } 
            for (int i = 0; i < 20; i++)
            {
                Console.Write("");
                Thread.Sleep(20);
            }

            Console.WriteLine("Первый поток завершен.");

            Console.WriteLine(new string('-', 25));

            Task task3 = Task.Run((MyTask));
            {
                Console.WriteLine("Второй поток запущен");
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("");
                Thread.Sleep(30);
            }
            Console.WriteLine("Второй поток завершен.");
            Console.ReadLine();
           
        }
    }
}