//  Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

using System.ComponentModel.Design;

System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10 && number < 99)
{
    int firstNumber = number % 10;
    int secondNumber = number / 10;

    if (firstNumber > secondNumber)
    {
        System.Console.WriteLine($"Максимальное число равно {firstNumber}");
    }

    else
    {
        System.Console.WriteLine($"Максимальное число равно {secondNumber} ");
    }
}
else
{
    System.Console.WriteLine("Введите корректное число ");
}