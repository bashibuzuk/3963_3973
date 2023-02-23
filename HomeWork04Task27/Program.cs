// Задача 27: 
// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// *Сделать оценку времени алгоритма через числа и строки

// 452 -> 11
// 82 -> 10
// 9012 -> 12

//принимает на вход число
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Суммирует через Integer
int SummAllNumbers (int Number)
{
    int result = 0;
    while (Number > 0)
    {
        result = result + Number%10;
        Number = Number/10;
    }
    return result;

}

//метод Печать
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int NumberInt = ReadData("Введите любое число: ");                  //записывает значение в виде integer

DateTime Time = DateTime.Now;                                       //
PrintResult("Сумма чисел равна " + SummAllNumbers(NumberInt));      // Суммирование через Integer
Console.WriteLine($"Затраченное время первым методом: {DateTime.Now - Time}");                             //

  //записывает значение в виде string

//Метод: Суммирует через String
int SummAllNumbers2(int NumberInt)
{
    string  NumberStr = NumberInt.ToString();
    char[] words = NumberStr.ToCharArray();
    int count = words.Length;
    int result = 0;
    for (int i = 0; i <= count - 1; i++)
    {
        result = result + (int)Char.GetNumericValue(words[i]);
    }
    return result;
}

DateTime Time2 = DateTime.Now;                                                      //
PrintResult("Сумма чисел равна " + SummAllNumbers2(NumberInt));                     // Суммирует через String
Console.WriteLine($"Затраченное время вторым методом: {DateTime.Now - Time2}");     // 