// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 20, 23);
    PrintArray(array);
    System.Console.WriteLine(CountNumbers(array, 7, 1));
}

int CountNumbers(int[] myArray, int div, int end)
{
    int count = 0;

    foreach(int number in myArray)
        if(number % div == 0 && number % 10 == end)
            count++;

    return count;
}

void PrintArray(int[] arrayForPrint)
{
    for(int i = 0; i < arrayForPrint.Length; i++)
        System.Console.Write(arrayForPrint[i] + " ");
    System.Console.WriteLine();
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(minRange, maxRange);

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
