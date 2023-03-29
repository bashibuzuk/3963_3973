// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Random numSint = new System.Random();

int rndNumber = numSint.Next(10,999999999);             // синтез случайного числа
Console.WriteLine($"Случайное число {rndNumber}");
if (rndNumber < 100)                                    //  проверка случайного числа на двузначность
{
    Console.WriteLine("Третьей цифры нет");
}
else                                                    // запуск цикла, который будет работать до тех пор, пока
{                                                       //число не станет трехначным
    while(rndNumber > 1000)
    {
        rndNumber = rndNumber/10;
    }
Console.WriteLine($"Третье число равно - {rndNumber%10}");
}