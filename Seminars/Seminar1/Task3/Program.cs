// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

System.Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99 && number < 1000) // '&&' -> логическое "И"
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int result = leftDigit + rightDigit;
    System.Console.WriteLine(result);
    // System.Console.WriteLine(number / 100 + number % 10);
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!");
}
