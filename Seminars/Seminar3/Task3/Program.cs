// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

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
    System.Console.Write(array[i] + " ");
}

int[] newArray = new int[array.Length / 2];

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}               

System.Console.WriteLine();
for (int i = 0; i < newArray.Length; i++)
{
    System.Console.Write(newArray[i] + " ");
}