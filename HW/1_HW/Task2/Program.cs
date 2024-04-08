// Напишите программу,  которая  принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max)
{
    max = secondNumber;
}
else
{
    max = firstNumber;
}

if (thirdNumber > max)
{
    max = thirdNumber;
}
else
{
    max = max;
}

Console.WriteLine("Максимальное число равняется: ");
Console.WriteLine(max);
