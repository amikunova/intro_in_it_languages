// Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// 

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(1, 100);
  System.Console.Write(array[i] + " ");
  
  if (array[i] >= 10 && array[i] <= 90)
  {
    count++;
  }
}

Console.WriteLine();
System.Console.Write($"количество элементов массива, значения которых лежат в отрезке [10,90] = {count}");
Console.WriteLine();


