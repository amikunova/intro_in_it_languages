// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int[] array = {1, 2, 7, 4};
    PrintArray(array, array.Length - 1);
    Console.WriteLine();
}
    
void PrintArray(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArray(array, index - 1);
    }
}

Main();
