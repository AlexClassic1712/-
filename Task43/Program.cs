//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)


Console.WriteLine("Введите коэффициент k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 == b2)
Console.WriteLine("Прямые совпадают");
else if(k1 == k2 && b1 != b2)
Console.WriteLine("Прямые параллельны");
else PrintIntersectionPoint(IntersectionPoint(k1, b1, k2, b2));

double[] IntersectionPoint(double k1, double b1, double k2, double b2)
{
  
    double x =(b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    
    double mX = Math.Round(x,1, MidpointRounding.AwayFromZero);
    double mY = Math.Round(y,1, MidpointRounding.AwayFromZero);
    double[] arr = {mX, mY};

    return arr;
}
 
 void PrintIntersectionPoint(double[] arr)
 {
    Console.WriteLine($"Точка пересечения прямых ({arr[0]} ; {arr[1]})");

 }