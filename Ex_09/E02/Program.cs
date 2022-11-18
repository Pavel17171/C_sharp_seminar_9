// E02 Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Вывод суммы целых чисел от M до N");
Console.WriteLine("Введите число M:");
int numM = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N:");
int numN = int.Parse(Console.ReadLine() ?? "0");

void SumElemFromMToN(int num1, int num2, int sum)
{
    if (num1 <= num2)
    {
        SumElemFromMToN(num1 + 1, num2, sum + num1);        
    }
    else
    {
    Console.WriteLine(sum);
    }
}

SumElemFromMToN(numM, numN, 0);