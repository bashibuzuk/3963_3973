// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int RecMN(int m, int n)
{
    int res = 0;
    if (m >= n)
    {
        res = res + n;
    }
    else
    {
        res = res + m  + RecMN(m + 1, n);
    }
    return res;
}

void PrintData(int msg)
{
    Console.WriteLine(msg);
}

int m = ReadData("Enter your first number: ");
int n = ReadData("Enetr your second number: ");
int result = 0;

if (m < n) result = RecMN(m, n);
else result = RecMN(n, m);

PrintData(result);