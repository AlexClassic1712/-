Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int countDigit = CountDigit(num);
Console.WriteLine($"В числе {num} содержится {countDigit} цифр(ы)");

int CountDigit(int number)
{
    int digit = 0;
    do
    {
        number /= 10; //number = number / 10
        digit++;
    } while (number != 0);
    return digit;
}