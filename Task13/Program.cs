Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number >= 100 ? $"третья цифра -> {num(number)}" : "третьей цифры нет");

int num ( int n)
{  
     int a = n;
 
  for(int i = n; i >= 1000; i/=10)
        
        a = a / 10;
             
    return  a % 10;
}
