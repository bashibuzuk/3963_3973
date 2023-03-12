// Задача 64: 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.

// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


void PrintNumbers(int n)
{
    if (n == 1)
    {
        Console.Write(n + " ");
    }
    else
    {
        PrintNumbers(n - 1);
        Console.Write(n + " ");
    }
}

void LineGenRec(int num)
{   
    Console.Write(num + " ");
    if (num == 1)
    {
    }
    else
    {
        LineGenRec(num - 1);
    }
    
}

int number = ReadData("Введите число N: ");
PrintNumbers(number);
Console.WriteLine();
LineGenRec(number);
Console.WriteLine();

