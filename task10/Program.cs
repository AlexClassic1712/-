Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(num (number));
int num ( int n)
{
    int a = n / 10;
    a = a % 10;
    return  a;
}
