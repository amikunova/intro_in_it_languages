// 
void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 10);
    PrintArray(array);

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
