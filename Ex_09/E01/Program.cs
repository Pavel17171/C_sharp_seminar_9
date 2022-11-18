// E01 Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Вывод чисел от M до N");
Console.WriteLine("Введите число M:");
int numM = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N:");
int numN = int.Parse(Console.ReadLine() ?? "0");

void PrintNumFromNToM(int num1, int num2)
{
    if (num1 <= num2)
    {
        Console.Write($"{num1} ");
        PrintNumFromNToM(num1+1, num2);
    }
}

PrintNumFromNToM(numM, numN);