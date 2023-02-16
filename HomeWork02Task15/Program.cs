//  Напишите программу, которая принимает на вход цифру, 
//,  обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите любое число");
int Number1 = int.Parse(Console.ReadLine()??"0");
int Result = Number1%7;
if (Result == 0 || Result == 6)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будень!!!");
}
