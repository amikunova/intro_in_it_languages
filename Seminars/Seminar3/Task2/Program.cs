// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11); // 0, 1, 2 ... 8, 9
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + "\t");
}

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}

System.Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + "\t");
}
