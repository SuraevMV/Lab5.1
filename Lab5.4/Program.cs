using System;

namespace Lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            int number = 0;

            for (int i = 1; i < n; i = i + 2)
            {
                if (array[i] > 0 && array[i] % 2 == 1)
                {
                    number++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах {0}", number);
            Console.ReadKey();
        }
    }
}
