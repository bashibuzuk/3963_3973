// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//принимает на вход произвольное число
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод суммирования всех чисел от M до N
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

//метод печати
void PrintData(int msg)
{
    Console.WriteLine(msg);
}

int m = ReadData("Enter your first number: ");
int n = ReadData("Enetr your second number: ");
int result = 0;

if (m < n) result = RecMN(m, n);  // проверка в случае, если пользователь ввел первое число
else result = RecMN(n, m);        //  больше второго

PrintData(result);