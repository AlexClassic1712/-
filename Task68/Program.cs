void ShowNumbers(int firstNum, int secondNum)
{
    if (firstNum < secondNum)
    {
        ShowNumbers(firstNum, secondNum - 1);
        Console.Write($"{secondNum} ");
    }
    else if (firstNum > secondNum)
    {
        Console.Write($"{firstNum} ");
        ShowNumbers(firstNum - 1, secondNum);
    }
    else
    {
        Console.Write($"{firstNum} ");
    }
}

Console.Write("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа от {numberM} до {numberN}: ");
ShowNumbers(numberM, numberN);