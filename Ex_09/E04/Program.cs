// E04 Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

Console.WriteLine("Введите количество чисел:");
int numN = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите первое целое число:");
int firstNum = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе целое число:");
int secondNum = int.Parse(Console.ReadLine() ?? "0");

void PrintNumers(int a, int b, int count, int n)
{
    {
        if (count == 1)
        {
        Console.Write($"{a} {b} ");
        count += 1;
        PrintNumers(a, b, count, n);
        }
        else if (count < n)
        {
            int temp = a;
            a = b;
            b = temp + a;
            Console.Write($"{b} ");
            count +=1;
            PrintNumers(a, b, count, n);
        }    
    }
}

PrintNumers(firstNum, secondNum, 1, numN);