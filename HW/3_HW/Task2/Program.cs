﻿// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    System.Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
System.Console.Write($"количество чётных чисел в массиве = {count}");
Console.WriteLine();
