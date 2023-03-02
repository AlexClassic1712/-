// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5-ти значное число");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom (num);
void Palindrom (int n)
{
    if (n >= 10000 && n <= 99999)
     {
        int a = n % 10;
        int b = (n / 10) % 10;
        int c = (n / 1000) % 10;
        int d = (n / 10000) % 10;
    if (a == d && b==c)
       Console.WriteLine("число является палиндромом");
  else Console.WriteLine("число НЕ является палиндромом");
    }
  else Console.WriteLine("введено не 5-ти значное число"); 
}
