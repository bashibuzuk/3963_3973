// Задача №28
// Напишите программу, которая принимает на 
// вход число N и выдаёт произведение чисел от 1 до N.

// Console.Clear();
// int ReadData(string WrDate)
// {
//     Console.WriteLine(WrDate);
//     int result = int.Parse(Console.ReadLine() ?? "0");
//     return result;
// }
// int number = ReadData("Введите число");

// long fact = 1;
// for (int x = 1; x <= number; x++)
// {
// fact *= x;
// }

// Console.WriteLine(fact);

using System.Numerics;

int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string message)
{
    Console.WriteLine(message);
}

BigInteger FactorCalc(int num)
{
    BigInteger fact = 1;
    for (int i = 2; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact;
}

int N = ReadData("Enter your value: ");
DateTime Time = DateTime.Now;
PrintData("The factorial of set value is " + FactorCalc(N));
Console.WriteLine(DateTime.Now - Time);

DateTime Time2 = DateTime.Now;
string msg = FactorCalc(N).ToString();
int count = msg.Length;
Console.WriteLine(count);
Console.WriteLine(Time2 - DateTime.Now);



