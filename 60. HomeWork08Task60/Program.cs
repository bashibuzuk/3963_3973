// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


//принимаем на вход произвольное число
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генерация 3х мерного массива случайных  чисел от 1 до 20
int[,,] Gen3DArr(int countRow, int countColumn, int countList)
{
    Random rnd = new Random();
    int[,,] arr = new int[countRow, countColumn, countList];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int z = 0; z < countList; z++)
            {
                arr[i, j, z] = rnd.Next(1, 20);
            }
        }
    }
    return arr;
}

//печать массива  случайных чисел
void Print3DArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                Console.Write($"В индексе ({i},{j},{z}) находится значение {arr[i, j, z]}");
                Console.WriteLine();
            }
        }
        
    }
}


int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int list = ReadData("Введите количество листов ");
int[,,] arr3D = Gen3DArr(row, column, list);                     
              
Print3DArr(arr3D);                                        
