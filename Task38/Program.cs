// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

DifferenceMaxMinElement(CreateArrayRndDouble(5, 2, 70));
double DifferenceMaxMinElement(double[] arr)
{
    double MinElement = arr[0];
    double MaxElement = arr[0];
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > MaxElement)
            MaxElement = arr[i];
       else if (arr[i] < MinElement)
           MinElement = arr[i];
    }
    Console.WriteLine();
    //res = MaxElement - MinElement;
    Console.WriteLine($"разница между максимальным и минимальным элементом массива {Math.Round(MaxElement - MinElement,1, MidpointRounding.AwayFromZero)}");
    return MaxElement - MinElement;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{

    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] =Math.Round(rnd.NextDouble() + rnd.Next(min, max), 1, MidpointRounding.AwayFromZero);

    }
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < size; i++)
        Console.Write($" {arr[i]} ");

    return arr;
}