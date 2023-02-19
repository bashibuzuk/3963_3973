// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// * Вывести таблицу с границами и значениями друг над другом



int ReadInput(string mess)
{
    Console.Write(mess);
    return int.Parse(Console.ReadLine()??"0");
}

string LineBuilder (int end, int pow)
{
    string res = String.Empty;
    for (int i = 1; i <= end; i++)
    {
        res = res + Math.Pow(i, pow)+"\t|";
    }

    return res;

}

string Lineyaka (int end)
{
    string res = String.Empty;
    for (int i = 1; i <= end; i++)
    {
        res = res + "________";
    }

    return res;

}

int N = ReadInput("Введите число: ");
Console.WriteLine(Lineyaka(N));
Console.WriteLine(LineBuilder(N, 1));
Console.WriteLine(Lineyaka(N));
Console.WriteLine(LineBuilder(N, 3));
Console.WriteLine(Lineyaka(N));