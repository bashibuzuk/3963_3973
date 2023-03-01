// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// *Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

//принимает на вход число нажатий
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод записи чисел в массив
int[] CountRecord(int number1)
{
    int[] FullNumber = new int[number1];
    for (int i = 0; i < number1; i++)
    {
        Console.Write($"Введите {i+1}ое число - ");
        FullNumber[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    return FullNumber;

}

//метод подсчёта чисел больше ноля
int CountNull (int[] number2)
{
    int count = 0;
    for (int i = 0; i < number2.Length; i++)
    {
        if (number2[i] > 0) count++;
    }
    return count;
}



int[] number2 = CountRecord(ReadData("Введите количество цифр: "));
Console.WriteLine($"Количество цифр больше нуля - {CountNull(number2)}");
