//// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void Main()
{
    System.Console.Write("Введите текст: ");
    string? str = Console.ReadLine();
    PrintConsonant(str);

}

void PrintConsonant(string? str)
{
    if (str!.Length < 1) return;

    char tempChar = char.ToLower(str[0]);
    if (isConsonant(tempChar))
        System.Console.Write(str[0] + " ");

    PrintConsonant(str[1..]);
}

bool isConsonant(char c)
{
    return "bcdfghjklmnpqrstvxzw".Contains(c);
}

Main();