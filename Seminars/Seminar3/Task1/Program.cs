// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

// 1-й способ
// int[] array = { 1, 55, 7, 12, 14 };

// 2-й способ
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// System.Console.WriteLine("Введите значения массива: ");
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write($"{i}-й элемент: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// System.Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + " ");
// }

// 3-й способ:
System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 10); // 0, 1, 2 ... 8, 9
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}

