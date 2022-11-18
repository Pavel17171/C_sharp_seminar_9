// E03 Написать программу вычисления функции Аккермана

Console.WriteLine("Вычисления функции Аккермана");
Console.WriteLine("Введите целое положительное число m:");
int numM = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите целое положительное число n:");
int numN = int.Parse(Console.ReadLine() ?? "0");

static int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return Akkerman(m, n);
}

Console.WriteLine($"Результат: {Akkerman(numM, numN)}");