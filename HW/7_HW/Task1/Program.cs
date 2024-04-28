// Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Main()
{
    int numberM = ReadInt("Введите значение M: ");
    int numberN = ReadInt("Введите значение N: ");
    PrintNaturalNumbers(numberM, numberN);
    Console.WriteLine();
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNaturalNumbers(int numberM, int numberN)
{
    if (numberM > 0)
    {
        Console.Write(numberM + " ");
    }
    
    if (numberM < numberN)
    {
        PrintNaturalNumbers(numberM + 1, numberN);
    }
    
}

Main();
