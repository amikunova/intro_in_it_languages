// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую

System.Console.Write("Введите натуральное число: ");
long number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    string numberStr = number.ToString();
    char[] array = numberStr.ToCharArray();
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]},");
        }
    }

    Console.WriteLine();
}
else
{
    System.Console.Write("Введите корректное число ");
}