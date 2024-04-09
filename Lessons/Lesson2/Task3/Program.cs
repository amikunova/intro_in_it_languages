//int n = 10;

int[] array = { 1, 2, 3, 5, 8, 35, 1, 3, 8, 5 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }

    i++;
}