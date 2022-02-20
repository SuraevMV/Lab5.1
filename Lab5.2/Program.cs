using System;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();             
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < n; i++)
            {
                if (max < array[i])                
                    max = array[i];
                
                if (min > array[i])
                    min = array[i];                
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное и минимальное значение равны соответсвенно {0} и {1}",max,min);
            Console.ReadKey();
        }
    }
}
