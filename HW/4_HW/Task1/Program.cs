// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


while (true)
{
    Console.WriteLine("Введите число:");
    string input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        Console.WriteLine("Вы ввели 'q', программа завершена");
        return;
    }

    int sum = 0;

    foreach (char digit in input)
    {
        if (!char.IsDigit(digit))
        {
            Console.WriteLine("Ошибка: введенное значение не является цифрой");
            sum = 0;
            break;
        }
        
        sum = int.Parse(digit.ToString()) + sum;
    }

    if (sum == 0)
    {
        continue;
    }
    
    if (sum % 2 == 0)
    {
        Console.WriteLine("Сумма цифр числа чётная, программа завершена");
        return;
    }
    
}