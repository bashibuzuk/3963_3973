// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// *Найдите площадь треугольника образованного пересечением 3 прямых

int k1 = 5; 
int k2 = 6; 
int k3 = -8;
int b1 = 4; 
int b2 = 9; 
int b3 = 10;

//Метод нахождение пересечения двух функций
(int resultX, int resultY) CrossPoint (int k1, int b1, int k2, int b2)
{
    int result1 = (b2 - b1)/ (k1 - k2);
    int result2 = (k1*result1) + b1;
    return (result1, result2);
}

//Метод нахождение длинны между двумя точками
double LengthSide ((int resultX, int resultY) Point1, (int resultX, int resultY) Point2)
{
    double length = Math.Sqrt((Math.Pow((Point1.resultX-Point2.resultX), 2) + Math.Pow((Point1.resultY-Point2.resultY),2)));
    return length;
}

//Метод подсчета площади треугольника
double SquareTriangle (double A, double B, double C)
{
    double H2 = (A+B+C)/2;
    double Square = Math.Sqrt(H2*(H2-A)*(H2-B)*(H2-C));
    return Square;
}

(int resultX, int resultY) Point1 = CrossPoint(k1, b1, k2, b2);
(int resultX, int resultY) Point2 = CrossPoint(k1, b1, k3, b3);
(int resultX, int resultY) Point3 = CrossPoint(k2, b2, k3, b3);
Console.WriteLine($"Угла треугольника равны {Point1}, {Point2}, {Point3}");
double Side1 = LengthSide(Point1, Point2);
double Side2 = LengthSide(Point1, Point3);
double Side3 = LengthSide(Point2, Point3);
Console.WriteLine($"Стороны треугольника равны {Side1} | {Side2} | {Side3}");
Console.WriteLine($"Площадь треугольника равна {SquareTriangle(Side1, Side2, Side3)}");
