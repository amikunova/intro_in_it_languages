﻿//Задача 1: Напишите программу, которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23, введите другое число");
}
