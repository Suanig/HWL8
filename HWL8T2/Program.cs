// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

namespace BabbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colCount = 6;//m
            int rowCount = 5;//n
            int[,] arr = GenerateArray(rowCount, colCount);
            Console.WriteLine("Исходный массив");
            PrintArray(arr);
            SumStringMatrix(arr);

            

        }
        public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = source[k];
                else
                    dest[k, dim] = source[k];
            }
        }
        public static int[,] GenerateArray(int t, int i)
        {
            int[,] table = new int[t, i];
            Random random = new Random();
            for (int a = 0; a < t; a++)
            {
                for (int b = 0; b < i; b++)
                {
                    table[a, b] = random.Next(-100, 100);
                }
            }
            return table;
        }
        public static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
        static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] > inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }
        static void SumStringMatrix(int[,] matrix)
        {
            int index = 0, minsum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine($"Сумма {i + 1} строки = {sum}");
                if (i == 0)
                {
                    minsum = sum;
                }
                else if (sum < minsum)
                {
                    minsum = sum;
                    index = i;
                }
            }
            string line = string.Empty;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                line += matrix[index, j] + " ";
            }
            Console.WriteLine($"Строка с минимальной суммой элементов {index + 1}. ");
        }

    }
}