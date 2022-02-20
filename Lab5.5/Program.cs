using System;

namespace Lab5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[n, n];
            #region
            for (int i = 0; i < n; i = i + 2)
            {
                for (int j = 0; j < n; j = j + 2)
                {
                    t[i, j] = 1;
                }                
            }

            for (int i = 1; i < n; i = i + 2)
            {
                for (int j = 1; j < n; j = j + 2)
                {
                    t[i, j] = 1;
                }                
            }
            #endregion
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
