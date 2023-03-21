// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

Exponentiation(a, b);

int Exponentiation(int a, int b)
{
    int c = 1;
    while (b >= 1)
    {
        c *= a;
        b--;

    }
    Console.WriteLine($"А в степени В = {c}");
    return c;
}
