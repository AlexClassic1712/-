﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задайти число N");
int n = Convert.ToInt32(Console.ReadLine());
PrintOnNto1(n);

void PrintOnNto1(int num)
{
   if(num == 0) return;
   Console.Write($"{num} ");
   PrintOnNto1(num - 1);
   
}

