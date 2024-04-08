// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int middleDigit = number / 10 % 10;
    int rightDigit = number % 10;
    int result = 1;

    for(int i = 0; i < rightDigit; i++)
    {
        result *= middleDigit; // result = result * rightDigit;
    }

    System.Console.WriteLine(result);

    // System.Console.WriteLine(Math.Pow(middleDigit, rightDigit));
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!");
}