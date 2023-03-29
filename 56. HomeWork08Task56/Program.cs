// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//принмаем на вход произвольное число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генерация массива случайных  чисел от 1 до 20
int[,] Gen2DArr(int countRow, int countColumn)
{
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(1, 20);
        }
    }
    return arr;
}

//печать массива  случайных чисел
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            {
                Console.Write(arr[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}

//метод подсчета суммы значения по строкам из принятого на вход массива
int [] SummRow(int[,] Gen2DArr)
{
    int[] SummRowNum = new int[Gen2DArr.GetLength(0)];
    int result = 0;
    for (int i = 0; i < Gen2DArr.GetLength(0); i++)
    {
        result = 0;
        for (int j = 0; j < Gen2DArr.GetLength(1); j++)
        {
            result += Gen2DArr[i, j];
            
        }
        SummRowNum[i] = result;
    }
    return SummRowNum;
}

//печать  сумм значений массива  по строкам
void PrintSummRow(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Строка {i+1} равна {array[i]}");
    }
}

//печать номера строки с самым маленьким значением 
void PrintMinRow(int[] array)
{
    int min = array[0];
    int k = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i]; 
            k = i+1;
        }
    }
    Console.WriteLine($"Строчка с самым маленькой суммой: {k} ({min})");

}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Gen2DArr(row, column);
Print2DArr(arr2D);
int[] SummRowNum = SummRow(arr2D);

Console.WriteLine();
PrintSummRow(SummRowNum);

Console.WriteLine();
PrintMinRow(SummRowNum);
