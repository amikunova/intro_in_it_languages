// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

System.Console.Write("Введите трехзначное число: ");
string? stringNumber = Console.ReadLine();

if (stringNumber?.Length == 3)
{
    System.Console.WriteLine(stringNumber[0] + "" + stringNumber[2]);
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!");
}

// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;

    // System.Console.WriteLine(leftDigit + "" + rightDigit);
    
    int result = leftDigit * 10 + rightDigit;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Введено не трехзначное число!");
}
