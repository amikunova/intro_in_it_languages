//  Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.


char[,] charArray = { { '1', '2', '3' }, { '4', '5', '6' } };

// string str = new string(charArray.Cast<char>().ToArray());
//
// Console.WriteLine(str);

string str = "";

foreach (char letter in charArray)
{
    str = str + letter;
}
Console.WriteLine(str);