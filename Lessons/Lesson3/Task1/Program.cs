﻿// Лекция 3. Функции

// int Square(int value)
// {
//     int result = value * value;
//     return result;
// }

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

double result = CalculateFormula(1,2, 3, 4);
Console.WriteLine(result);