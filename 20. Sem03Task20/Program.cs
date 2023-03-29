// Задача №20
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.

int ReadData (string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()?? "0");
}

void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}

double CalcLen2D (int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

int x1 = ReadData("Введите координату x точка А: ");
int y1 = ReadData("Введите координату y точка А: ");
int x2 = ReadData("Введите координату x точка B: ");
int y2 = ReadData("Введите координату y точка B: ");

double res = CalcLen2D (x1, x2, y1, y2);

PrintData ("Расстояние меджу точками А и В:", res);
