Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(num (number));

int num ( int n)
{    int a = n;
    if(n <= 99)
    Console.WriteLine("Третьей цифры нет");
    
    else 
    
        for(int i = a; i <= 99; i/=10)
    {
        a = a / 10;
    }
    
    
    return  a % 10;
}
