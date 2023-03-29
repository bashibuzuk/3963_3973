//Возведение в степень методом рекурсии

Console.Clear();
int ReadData(string WrDate)
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

long MyPow(int a, int b)
{

    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * MyPow(a, b - 1);
    }

}

int a = ReadData("Введите число a: ");
int b = ReadData("Введите число b: ");

long res = MyPow(a, b);
Console.WriteLine(res);
