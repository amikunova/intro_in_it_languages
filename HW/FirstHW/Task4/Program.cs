//Напишите программу,которая на вход принимает число (number), а на выходе выводит все чётные числа
//от 1 до number (включительно), после каждого числа должен быть знак пробела.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}
