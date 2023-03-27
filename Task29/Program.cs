
int size = 8;
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
    arr[i] = rnd.Next(2, 7 + 1);
    Console.Write($"{arr[i]} ");
}
PrintArray(arr);

void PrintArray(int[] arr)
{
    Console.Write("-> [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}