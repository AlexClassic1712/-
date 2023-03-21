// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;

while (a > 1)
{
    b += a % 10;
    a = a / 10;
}
Console.WriteLine($"сумма цифр в введенном числе {b}");

