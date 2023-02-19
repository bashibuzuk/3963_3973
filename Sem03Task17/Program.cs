//принимает на вход X и Y? а на выход даёт название четверти


int ReadInput(string mess)
{
    Console.Write(mess);
    return int.Parse(Console.ReadLine() ?? "0");
}

void quarter(int X, int Y)
{
    if (X > 0 && Y > 0) Console.WriteLine("Это первая четверть");
    if (X > 0 && Y < 0) Console.WriteLine("Это вторая четверть");
    if (X < 0 && Y < 0) Console.WriteLine("Это третья четверть");
    if (X < 0 && Y > 0) Console.WriteLine("Это четвертая четверть");
}

int Number1 = ReadInput("Введите чило Х:");
int Number2 = ReadInput("Введите чило У:");
quarter(Number1, Number2);