// Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = "шалаш";

bool isPalindrom(string str)
{
    string revString = new string(str.Reverse().ToArray());
    return str == revString;
}

if (isPalindrom(str))
{
    Console.WriteLine("Строка палиндром");
}
else
{
    Console.WriteLine("Строка не является палиндромом");
}