// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

System.Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// int i = -number;
// while (i <= number)
// {
//     System.Console.Write(i + " ");
//     i++; // i = i + 1; i += 1;
// }

for (int i = -number; i <= number; i++)
    System.Console.Write(i + " ");
