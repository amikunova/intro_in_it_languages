// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]

int number = new Random().Next(100, 1000);
System.Console.WriteLine("Сгенерированное число: " + number);

int[] array = new int[3];

for (int i = 0; i < array.Length; i++)
{
    array[i] = number % 10;
    number /= 10;
}

for(int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}