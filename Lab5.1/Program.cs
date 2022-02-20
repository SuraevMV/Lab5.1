using System;

namespace Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            float s = 0;
            int[] array = new int[n];            
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];                
            }            
            Console.WriteLine("Среднее арифмитическое чисел {0:f3}",s/n);
            Console.ReadKey();
        }
    }
}
