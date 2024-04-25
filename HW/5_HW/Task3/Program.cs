// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void Main()
{
    int[,] array =
    {
        { 1, 12, 3, 7 },
        { 5, 6, 7, 13 },
        { 9, 10, 11, 4 }
    };

    int rowMin = FindRowWithMinSum(array);
    Console.WriteLine(rowMin);   
}

int FindRowWithMinSum(int[,] array)
{
    int sumMin = CalculateSumOfRow(array,0);
    
    for (int iOfRow = 1; iOfRow < array.GetLength(0); iOfRow++)
    {
       int sum = CalculateSumOfRow(array, iOfRow);

       if (sumMin > sum)
       {
           sumMin = sum;
       }
    }
    return sumMin;
}

int CalculateSumOfRow(int[,] array, int iOfRow)
{
    int sum = 0;
    for (int iOfColumn = 0; iOfColumn < array.GetLength(1); iOfColumn++)
    {
        sum = sum + array[iOfRow, iOfColumn];
    }

    return sum;
}

Main();