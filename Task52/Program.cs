// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndint(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j]= rnd.Next(min, max); 
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
            Console.Write($"{matrix[i, j], 3}");  //Console.Write("{0,5:F1}", matrix[i, j]); 
        }
        Console.WriteLine();
    }
}

double [] AvgArifColumns(int [,]arr)
{
    double count = 0;
    double [] res = new double [arr.GetLength(1)];
    
     for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            count += arr[i, j]; 
            
             if (i == arr.GetLength(0)-1)
           { 
                 res[j] = Math.Round(count/(i+1),1);
                 count = 0;
            }  
         }
       
    }

    return res;
}

void printRes(double [] arr)
{
    Console.Write("среднее арифметическое столбцов:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i], 4}; ");
    }
}

int [,] arr2d = CreateMatrixRndint(3,4, -10, 11);
PrintMatrix(arr2d);
printRes(AvgArifColumns(arr2d));

