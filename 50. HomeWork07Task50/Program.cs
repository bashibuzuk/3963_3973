// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// *Заполнить числами Фиббоначи и выделить цветом найденную цифру

//принятие числа на вход
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//генерация чисел Фиббоначи в массив
int[] GenerateFibonacciNumbers(int count)
{
    int[] fibonacciNumbers = new int[count];
    fibonacciNumbers[0] = 0;
    fibonacciNumbers[1] = 1;

    for (int i = 2; i < count; i++)
    {
        fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
    }

    return fibonacciNumbers;
}

//перевод массива чисел Фиббоначи в матрицу
int[,] Gen2DArr(int countRow, int countColumn, int[]fibonacciNumbers)
{
    
    int[,] arr = new int[countRow, countColumn];
    int count = 0;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
                arr[i, j] = fibonacciNumbers[count];
                count++;
        }
    }
    return arr;
}

//печать массива с подсветкой желтым нужного числа
void Print2DArr(int[,] arr, int SeekCount)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        if (arr[i, j] == SeekCount)
        {
            Console.ForegroundColor = col[0];
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor();    
        }
        else
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int seekCount = ReadData("Введите число, которое необходимо найти ");
int[] fibonacciNumbers = GenerateFibonacciNumbers(row*column); 
int[,] arr2D = Gen2DArr(row, column, fibonacciNumbers);
Print2DArr(arr2D, seekCount);





