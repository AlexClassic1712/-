// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndint(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
        Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

void MinSumRows(int[,] arr)
{
    int[] buf = new int[arr.GetLength(1) + 1]; // создание одномерного массива, для записи строк из arr[,]
    int temp;
    int res = 0;
    int row = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        temp = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           temp += arr[i, j]; // суммируем i-ю строку
           
            if (j == arr.GetLength(1) - 1)
            {
                if (i == 0) 
                {
                    res = temp; 
                    row = i+1;
                }
                else if (res > temp)
                {
                    res = temp;
                    row = i+1;
                }
            }
        }

    }

    Console.WriteLine($"Строка с наименьшей суммой: {row}-я. Сумма строки: {res}");
}

int[,] matrix = CreateMatrixRndint(6, 4, 2, 10);
Console.WriteLine("исходный массив:");
PrintMatrix(matrix);

//Console.WriteLine("Отсортированный массив:");
MinSumRows(matrix);