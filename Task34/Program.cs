

CountEvenNumber(CreateArrayRndInt(10, 100, 522));


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

void CountEvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]% 2 == 0 )
        count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Колличество четных элементов = {count}");
}