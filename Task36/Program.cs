// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

SummUnevenElement(CreateArrayRndInt(11, -50, 50));
int SummUnevenElement(int [] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        summ+=arr[i];
             
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на нечетных позициях =  {summ}");
    return summ;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
       
    }
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < size; i++)
    Console.Write($" {arr[i]} ");
    
    return arr;
}