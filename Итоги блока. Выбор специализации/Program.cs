// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []



//метод принятия на вход произвольного числа
int Read2Data(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод принятия на вход произвольного значения
string ReadDataString(string message)
{
    Console.Write(message);
    return Console.ReadLine() ?? "0";
}

//метод создания массива с клавиатуры
string[]NewMassive(int LengthMassive)
{
    string[]arr = new string[LengthMassive];
    for (int i = 0; i < LengthMassive; i++)
    {
        arr[i] = ReadDataString($"Введите значение {i+1}: ");
    }
    return arr;

}

//метод формирования массива со значениями меньше или равно 3
string[]Result(string[]massive)
{
    string[]arr = new string[0];
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <= 3)
        {
            arr = arr.Concat(new string[] { massive[i] }).ToArray();
        }
    }
    return arr;
}

//печать массива
void Print1DArr(string[] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]},\t");
    }
}


int LengthMassive = Read2Data("Задайте длинну массива"); // задать длинну массива
string[]array = NewMassive(LengthMassive);               // запись значений в массив

Print1DArr(Result(array));                               // печать массива со значениями меньше или равно 3
Console.WriteLine();