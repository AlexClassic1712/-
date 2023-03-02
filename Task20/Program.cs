// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите координаты точки А");
int xCoordA = Convert.ToInt32(Console.ReadLine());
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Б");
int xCoordB = Convert.ToInt32(Console.ReadLine());
int yCoordB = Convert.ToInt32(Console.ReadLine());

double distance = FindAB(xCoordA, yCoordA, xCoordB, yCoordB);
Console.WriteLine($"Расстояние между точками равно: {Math.Round(distance, 2, MidpointRounding.ToZero)}");

double FindAB (int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(xA-xB, 2) + Math.Pow(yA-yB, 2)); 
}

Math.Sqrt(5);
double res = 5.09987564;
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
