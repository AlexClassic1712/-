// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndint(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");  //Console.Write("{0,5:F1}", matrix[i, j]); 
        }
        Console.WriteLine();
    }
}

int[,] SortRowsElement(int[,] arr)
{
    int[] buf = new int[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            buf[j] = arr[i, j];

            if (j == arr.GetLength(1) - 1)
            {
                int l = 0, c, flag;
                do                  //улучшенная сортировка
                {     
                    flag = 0;
                    for (int k = buf.Length - 2; k >= l; k--)

                        if (buf[k] < buf[k + 1])
                        {
                            c = buf[k];
                            buf[k] = buf[k + 1];
                            buf[k + 1] = c;
                            flag = 1;
                        }
                    l++;
                } while (flag != 0);

                for (int a = 0; a < arr.GetLength(1); a++) // запись отсортированной строки в двумерный массив
                    arr[i, a] = buf[a];
            }
        }

    }

    return arr;
}
int[,] matrix = CreateMatrixRndint(3, 40, 2, 30);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);

Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintMatrix(SortRowsElement(matrix));