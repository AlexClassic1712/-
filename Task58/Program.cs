// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {

        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int n = 0; n < matrix2.GetLength(0); n++)
            {
                result[i, j] += matrix1[i, n] * matrix2[n, j];
            }
        }

    }
    return result;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");  //Console.Write("{0,5:F1}", matrix[i, j]); 
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность 1-ой матрицы:");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr1 = CreateMatrixRndint(rows, columns, 1, 10);
PrintMatrix(arr1);

Console.WriteLine("Введите размерность 1-ой матрицы:");
rows = Convert.ToInt32(Console.ReadLine());
columns = Convert.ToInt32(Console.ReadLine());
int[,] arr2 = CreateMatrixRndint(rows, columns, 1, 5);
PrintMatrix(arr2);
if (arr1.GetLength(0) != arr2.GetLength(1))
    Console.WriteLine("Матрицы не могут быть перемножены из-за неравенства количества столбцов 1-й матрицы количеству строк 2-й матрицы");
else
{
    Console.WriteLine("Результирующая матрица");
    PrintMatrix(MultiplicationMatrix(arr1, arr2));
}