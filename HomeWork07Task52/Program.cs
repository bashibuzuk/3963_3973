// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

//печать массива их случайных чисел
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

//метод подсчета среднего значения по столбикам из принятого на вход массива
double [] Mean(int[,] Gen2DArr)
{
    double[] MeanNum = new double[Gen2DArr.GetLength(1)];
    double result = 0;
    for (int i = 0; i < Gen2DArr.GetLength(1); i++)
    {
        result = 0;
        for (int j = 0; j < Gen2DArr.GetLength(0); j++)
        {
            result += Gen2DArr[j, i];
            
        }
        MeanNum[i] = Math.Round(result/Gen2DArr.GetLength(0), 2);
    }
    return MeanNum;
}

//печать среднего значания 
void PrintMean(double[] Mean)
{
    for (int i = 0; i < Mean.Length; i++)
    {
        Console.Write(Mean[i] + "\t");

    }

}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Gen2DArr(row, column);
Print2DArr(arr2D);
double[] MeanNum = Mean(arr2D);
Console.WriteLine();
PrintMean(MeanNum);
