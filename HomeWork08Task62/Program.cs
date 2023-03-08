// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



//принмаем на вход произвольное число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генерация массива   чисел, заполняемого по спирали
int[,] Gen2DArr(int countRow, int countColumn)
{
    
    int[,] arr = new int[countRow, countColumn];
    int count = 1;
    int j = 0;
    int n = 0;

    while (countColumn>0 || countRow>0)
    {
        //1 движение вправо по верхнему краю
        for (int i = n; i < countColumn; i++)
        {
            arr[j, i] = count;
            count++;
        }
        n++;
        countColumn-=1; 
        
        //2 движение вниз по правому краю
        for (int i = n; i < countRow; i++)
        {
            arr[i, countColumn] = count;
            count++;
        }
        countRow-=1; 

        //3 движение влево по нижнему краю
        for (int i = countColumn-1; i >= j; i--)
        {
            arr[countRow, i] = count;
            count++;
        }
        
        //4 движение вверх по левому краю
        for (int i = countRow-1; i > j; i--)
        {
            arr[i, j] = count;
            count++;
        }
        j++;
    }
    return arr;
}

//печать массива  
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






int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int[,] arr2D1 = Gen2DArr(row, column);                     

Print2DArr(arr2D1);                                        
