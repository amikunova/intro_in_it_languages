int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 1000);
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrix(3,4);

foreach (int e in matrix)
{
    IsInteresting(e) 
}