// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

//метод перемножения двух матриц
int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);

    int[,] result = new int[rows1, cols1];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols1; j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return result;
}




int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D1 = Gen2DArr(row, column);                     //генерируем первую матрицу
int[,] arr2D2 = Gen2DArr(row, column);                     //генерируем вторую матрицу
Print2DArr(arr2D1);                                        //печатаем первую матрицу

Console.WriteLine();
Print2DArr(arr2D2);                                        //печатаем вторую матрицу

Console.WriteLine();
Print2DArr(MatrixMultiply(arr2D1, arr2D2));                //печатаем перемноженную матрицу

