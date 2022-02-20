using System;

namespace Lab5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чсило столбцов и строк");
            int N = Convert.ToInt32(Console.ReadLine());
            int n = N;
            int m = N;
            int sn = 0;
            int sm = 0;
            int sd1 = 0;
            int sd2 = 0;
            bool f = false;
            int[,] array = new int[n, m];
            Console.WriteLine("Заполните матрицу");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //Заполнение матрицы
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }                
            }
            Console.WriteLine("Вывод введённой матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", array[i, j]); ;
                }
                Console.WriteLine();
            }
            //Сумма диагонали слева
            for (int j = 0, i = 0; j < m && i < n; j++, i++)
            {
                sd1 += array[i, j];
            }
            //Сумма диагонали справа
            for (int j = N - 1, i = 0; j >= 0 && i < n; j--, i++)
            {
                sd2 += array[i, j];
            }
            if (sd2 != sd1)
            {
                f = true;
            }
            //Сумма строк
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sn += array[i, j];
                }
                if (sd1 != sn)
                {
                    f = true;
                    break;
                }
                sn = 0;
            }
            //Сумма столбцов
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sm += array[i, j];
                }
                if (sd1 != sm)
                {
                    f = true;
                    break;
                }
                sm = 0;
            }
            if (f == false)
                Console.WriteLine("Матрица являеться магическим квадратом");
            else
                Console.WriteLine("Матрица являеться обычной");
        }
    }
}
