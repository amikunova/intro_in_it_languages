// Напишите программу,  которая на вход принимает два числа и выводит,
// какое число большее, а какое меньшее.

// firstNumber: '5'
// secondNumber: '6'

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{ 
    Console.WriteLine("Первое число больше второго");
}
else
{ 
    Console.WriteLine("Второе число больше первого");
}