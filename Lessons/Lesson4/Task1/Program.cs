
//создание функции генерации 2-го массива на основе случайных чисел
//Для создания функции нужно ответить на 3 вопроса:
//1)Что делает ф-ция,
//2)Какие данные ей нужны,
//3) Что будет результатом ее работы.

int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{ matrix[i, j]} "); 
        }
        Console.WriteLine();
    }  
}

void Main() {
    int[,] matrix = CreateMatrix(4,5);
    ShowMatrix(matrix);
}

Main();