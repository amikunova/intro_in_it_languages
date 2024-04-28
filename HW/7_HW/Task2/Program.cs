// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

void Main()
{
    int numberM = ReadInt("Введите значение m: ");
    int numberN = ReadInt("Введите значение n: ");
    Console.WriteLine($"Значение функции Акермана = " +A(numberM, numberN));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}

Main();