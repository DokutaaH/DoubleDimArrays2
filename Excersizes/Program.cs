using System;

namespace Excersizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[,] doubleArray = new int[n, m];

            int sumOfElements = 0;
            long productOfElements = 1;
            int count = 0;
            int avg;

            Console.WriteLine("Сгенерированный массив:");

            for (int i = 0; i < n; i++)
            {
                long productOfElemsInLine = 1;

                for (int j = 0; j < m; j++)
                {
                    doubleArray[i, j] = random.Next(-100, 100);
                    Console.Write(doubleArray[i, j] + ", ");

                    sumOfElements += doubleArray[i, j];
                    productOfElements *= doubleArray[i, j];
                    productOfElemsInLine *= doubleArray[i, j];
                    count++;
                }

                Console.WriteLine($"Произведение элементов в строке {i}: {productOfElemsInLine}");
            }

            Console.WriteLine();

            avg = sumOfElements / count;

            Console.WriteLine();
            Console.WriteLine("Сумма всех элементов: " + sumOfElements + "\n");
            Console.WriteLine("Произведение всех элементов: " + productOfElements + "\n");
            Console.WriteLine("Среднее арифметическое всех элементов: " + avg + "\n");
            Console.WriteLine("Нечетные элементы: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (doubleArray[i, j] % 2 != 0)
                    {
                        Console.Write(doubleArray[i, j] + ", ");
                    }
                }
            }
            
            Console.WriteLine();

            if (n == m)
            {
                Console.Write("Диагональ массива: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(doubleArray[i, i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Массив имеет неравное число строк и столбцов.");
            }

            for (int  i = 0;  i < n;  i++)
            {
                int temp = doubleArray[i, 0];
                doubleArray[i, 0] = doubleArray[i, 2];
                doubleArray[i, 2] = temp;
            }


            Console.WriteLine($"Поменяли местами столбцы 0 и 2: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(doubleArray[i, j] + ", ");
                }

                Console.WriteLine();
            }
        }
    }
}
