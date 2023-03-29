// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.


// принимается на вход число
int ReadData (string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()?? "0");
}

//вывод результата
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}

//рассчитывается расстояние между точками
double CalcLen3D (int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
}

int x1 = ReadData("Введите координату x точка А: ");
int y1 = ReadData("Введите координату y точка А: ");
int z1 = ReadData("Введите координату z точка А: ");

int x2 = ReadData("Введите координату x точка B: ");
int y2 = ReadData("Введите координату y точка B: ");
int z2 = ReadData("Введите координату z точка B: ");

double res = CalcLen3D (x1, x2, y1, y2, z1, z2);

PrintData ("Расстояние меджу точками А и В:", res);