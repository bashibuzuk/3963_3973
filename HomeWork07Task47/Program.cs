// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// *При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

// принимаем число на вход
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// генерация массива вещественных чисел с округлением до второго числа
double[,] Gen2DArr(int countRow, int countColumn)
{
    Random rnd = new Random();
    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = Math.Round((rnd.NextDouble() * 5), 2);
        }
    }
    return arr;
}
//печть массива с одновременной разукраской каждого знака вещественного числа
void Print2DArr(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            string numStr = arr[i, j].ToString(); // преобразуем число в строку
            char[] numArr = numStr.ToCharArray(); // преобразуем строку в массив символов
            for (int z = 0; z < numArr.Length; z++) // начинается цикл по разукрашиванию каждого знака
            {
                Console.ForegroundColor = col[new Random().Next(0, 15)];
                Console.Write(numArr[z]);
                Console.ResetColor();
            }
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
double[,] arr2D = Gen2DArr(row, column);
Print2DArr(arr2D);