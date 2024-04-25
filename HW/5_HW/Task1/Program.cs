// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет:
// "Позиция по рядам выходит за пределы массива"или"Позиция по колонкам выходит за пределы массива".
// Позиции в массиве считать от единицы. В коде, начальные условия:

void Main()
{
    int[,] numbers =
    {
        { 1, 2, 3, 4 },
        { 5, 6, 7, 8 },
        { 9, 10, 11, 12 }
    };

    Console.WriteLine("Введите значение x:");
    int x = Convert.ToInt32(Console.ReadLine());
    
    bool isXValid = ValidateCoordinate(x, numbers.GetLength(1));
    
    if (!isXValid)
    {
        Console.WriteLine("Позиция по колонкам выходит за пределы массива");
        
        Main();
        
        return;
    }
        
    Console.WriteLine("Введите значение y:");
    int y = Convert.ToInt32(Console.ReadLine());

    bool isYValid = ValidateCoordinate(y, numbers.GetLength(0));

    if (!isYValid)
    {
        Console.WriteLine("Позиция по рядам выходит за пределы массива");
        
        Main();
        
        return;
    }
    
    int result = GetElement(numbers, y, x);

    Console.WriteLine("ответ: " + result);
}

bool ValidateCoordinate(int value, int arrayLength)
{
    return value >= 0 && value < arrayLength;
}

static int GetElement(int[,] array, int y, int x)
{
    return array[y, x];
}

Main();