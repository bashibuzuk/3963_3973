// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

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

//Адаптированный Метод пузырька для массива
void SelectionBubbleForArray(int[,] array)
{
    for (int z = 0; z < array.GetLength(0); z++)
    {
        int len = array.GetLength(1);
        for (int i = 0; i < len; i++)
        {
            int len2 = array.GetLength(1) - 1;
            for (int j = 0; j < len2; j++)
            {
                if (array[z, j] > array[z, j + 1])
                {
                    int temporary = array[z, j];
                    array[z, j] = array[z, j + 1];
                    array[z, j + 1] = temporary;

                }


            }
        }
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D = Gen2DArr(row, column);
Print2DArr(arr2D);
SelectionBubbleForArray(arr2D);

Console.WriteLine();
Print2DArr(arr2D);
