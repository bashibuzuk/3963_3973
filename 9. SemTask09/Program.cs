//System.Random numSint = new System.Random();

//int rndNumber = numSint.Next(10,100);
//Console.WriteLine(rndNumber);
//int firstNum = rndNumber/10;
//int secNum = rndNumber%10;

//if(firstNum > secNum )
//{
//    Console.WriteLine(firstNum);
//}
//else
//{
//    Console.WriteLine(secNum);
//}

//Вариант 2

//char [] digit = numSint.Next(100,999).ToString().ToCharArray;
//int firstNum = ((int)digit[0])-48;
//int secNum = ((int)digit[1])-48;


//вариант 3

// System.Random numSint = new System.Random();
// int Num1 = numSint.Next(100,1000);
// Console.WriteLine(Num1);
// int LastDigit = Num1%10;
// int FirstDigit = Num1/100;

// int numFin = FirstDigit*10+LastDigit;
// Console.WriteLine(numFin);

//System.Random numSint = new System.Random();
//int Num1 = numSint.Next(100,1000);
//int Num2 = numSint.Next(100,1000);

//int Num1 = int.Parse(Console.ReadLine()??"0");
//int Num2 = int.Parse(Console.ReadLine()??"0");

//if (Num1%Num2 == 0)
//{
//    Console.WriteLine("Кратно");
//}
//else
//{
//    Console.WriteLine("не кратно");
//}

//Console.WriteLine("Введите любое число");
//int Num1 = int.Parse(Console.ReadLine()??"0");

//if ((Num1%7 == 0) && (Num1%23 == 0))
//{
//    Console.WriteLine("Делится");
//}
//else
//{
//    Console.WriteLine("Не делится");
//}

//Задача №16
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое  число");
int Number1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе  число");
int Number2 = int.Parse(Console.ReadLine()??"0");

if ((Number1*Number1 == Number2) || (Number2*Number2 == Number1))
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}
