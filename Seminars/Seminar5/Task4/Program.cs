// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 4 -> 13/4 = 3.(3)
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int column = ReadInt("Введите количество столбцов: ");
    int[,] myMatrix = GenerateMatrix(row, column, 0, 9);
    PrintMatrix(myMatrix);
    PrintArray(FindAverages(myMatrix));

}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("\t", array) + "]");
}

double[] FindAverages(int[,] matrix)
{
    double[] averages = new double[matrix.GetLength(0)];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            averages[i] += matrix[i,j];
        }
        averages[i] = Math.Round(averages[i] / matrix.GetLength(1), 2);
    }

    return averages;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

    System.Console.WriteLine();
}

int[,] GenerateMatrix(int row, int col, int minRange, int maxRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    for (int j = 0; j < tempMatrix.GetLength(1); j++)
        tempMatrix[i, j] = rand.Next(minRange, maxRange + 1);

    return tempMatrix;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
