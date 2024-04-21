// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

void Main()
{
    char[] chars = { 'a', 'b', 'c', 'd' };

    // 1-й вариант:
    // string str = new string(chars);

    // 2-й вариант:
    // string str = ArrayToString(chars);

    // 3-й вариант:
    // string str = string.Concat(chars);

    // 4-й вариант:
    string str = string.Join("", chars);
    System.Console.WriteLine(str);
}

string ArrayToString(char[] chars)
{
    string str = "";

    foreach (char letter in chars)
        str += letter;

    return str;
}

Main();