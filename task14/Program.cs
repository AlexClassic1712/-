Console.WriteLine("Введите первое число"); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число"); 
int numberB = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine(Sqrt(numberA, numberB)  ? "да" : "нет");  

 bool Sqrt(int numA, int numB)

{
         return numA * numA == numB || numB*numB == numA;
}