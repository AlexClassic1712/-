Console.Write("введите число N:");
int number = Convert.ToInt32(Console.ReadLine());
Quart(number);

void Quart (int n)
{
    for (int i = 1; i <= n; i++)
    Console.WriteLine($"куб числа {i,3} - {Math.Pow(i,3),3}");
}