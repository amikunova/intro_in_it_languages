// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.


void Main()
{
    int rowsCount = ReadInt("Введите количество строк: ");
    int columnsCount = ReadInt("Введите количество столбцов: ");
    int[,] array = GenerateArray(rowsCount,columnsCount);
    PrintArray(array);
    ChangeArray(array);
    PrintArray(array);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray(int rowsCount, int columnsCount)
{
    int[,] tempMatrix = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    for (int j = 0; j < tempMatrix.GetLength(1); j++)
        tempMatrix[i, j] = rand.Next(0,9);

    return tempMatrix;
}

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }

        System.Console.WriteLine();
    }

    System.Console.WriteLine();
}
Main();