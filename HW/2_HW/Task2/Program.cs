// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// 

System.Console.Write("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Нельзя указывать 0, введите другое число.");
} 
else if (x > 0 && y > 0)
{
    Console.WriteLine("Вы ввели координаты I четверти.");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Вы ввели координаты II четверти.");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Вы ввели координаты III четверти.");
}
else
{
    Console.WriteLine("Вы ввели координаты IV четверти.");
}

Console.WriteLine("Программа завершена.");