// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

// 1111911 % 1000 -> 911 / 100 -> 9

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    System.Console.WriteLine(number % 1000 / 100);
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}
//второй вариант
// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

// 1191111 / 10000 -> 119 % 10 -> 9

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    // while(number > 999)
    //     number /= 10;

    for ( ; number > 999; )
        number /= 10;

    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}