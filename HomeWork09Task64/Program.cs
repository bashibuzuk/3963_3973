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

//печать последовательность натуральных чисел от одного и до заданного
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



int number = ReadData("Введите число N: ");
PrintNumbers(number);
Console.WriteLine();


