Console.OutputEncoding = System.Text.Encoding.UTF8;

// 程序功能：输入上下限，输出区间内所有素数（每行一个）
Console.Write("请输入上限：");
int upper = ReadIntFromConsole();

Console.Write("请输入下限：");
int lower = ReadIntFromConsole();

if (lower > upper)
{
    int temp = lower;
    lower = upper;
    upper = temp;
}

Console.WriteLine($"[{lower}, {upper}] 区间内的素数有：");
for (int n = lower; n <= upper; n++)
{
    if (IsPrime(n))
    {
        Console.WriteLine(n);
    }
}

static int ReadIntFromConsole()
{
    while (true)
    {
        var input = Console.ReadLine();
        if (int.TryParse(input, out int value))
        {
            return value;
        }

        Console.Write("输入无效，请重新输入一个整数：");
    }
}

static bool IsPrime(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;

    int limit = (int)Math.Sqrt(n);
    for (int i = 3; i <= limit; i += 2)
    {
        if (n % i == 0) return false;
    }

    return true;
}
