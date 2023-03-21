Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int countDigit = CountDigit(num);
Console.WriteLine($"Факториал числа {num} равен {countDigit} ");

int CountDigit(int number)
{
    int digit = 1;
   
    for (int i = 1; i <= number; i++)
    {
        digit *= i; //number = number / 10
        
    } 
    return digit;
}