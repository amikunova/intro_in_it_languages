// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

void Main()
{
    System.Console.Write("Введите текст: ");
    string? str = Console.ReadLine(); 

    // char[] chars = str!.ToCharArray();
    // PrintArray(chars);

    char[] chars = StringToCharArray(str);
    PrintArray(chars);
}

char[] StringToCharArray(string? str)
{
    char[] tempChars = new char[str!.Length];

    for(int i = 0; i < str.Length; i++)
        tempChars[i] = str[i];

    return tempChars;
}


void PrintArray(char[] chars)
{
    System.Console.WriteLine("[" + string.Join(", ", chars) + " ]");
}

Main();
