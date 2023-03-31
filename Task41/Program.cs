Console.WriteLine("Введите колличество чисел, которое хотите ввести:");
int arrLenght = Convert.ToInt32(Console.ReadLine());

Polojit(arrLenght);
int Polojit(int size)
{
  int count=0;

    int[] arr = new int[size];
 Console.WriteLine("Введите произвольные целые числа:");
    
    for (int i = 0; i < size; i++)
    {
    arr[i] = Convert.ToInt32(Console.ReadLine());
   if (arr[i] > 0) count++;
    }
 Console.WriteLine($"Колличество положительных введенных чисел: {count}");
return count;
}