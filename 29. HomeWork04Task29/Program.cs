// Задача 29: 
// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
// Ввести с клавиатуры длину массива и диапазон значений элементов.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



//принимает на вход число
int Read2Data(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}


int[] Gen2DArr(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }

    return arr;
}  
//prints 1D array into consle
void Print1DArr(int[] arr)
{
    Console.Write("[");
     for (int i = 0; i < arr.Length - 1; i++) 
     Console.Write($"{arr[i]}, ");
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int len = Read2Data("Введите длинну массива: ");
int min = Read2Data("Введите минимальный диапазон: ");
int max = Read2Data("Введите максимальный диапазон: ");

Print1DArr(Gen2DArr(len, min, max));


// *Дополнительно: Написать программу которая из имен через запятую выберет случайное имя 
// и выведет в терминал Игорь, Антон, Сергей -> Антон Подсказка: 
// Для разбора строки использовать метод string.split(). 
// Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

//Записывает String
string ReadData(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine() ?? "0";
}

//Записывает Integer
int ReadData2(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Узнаёт сколько людей в компании
int AllFriends = ReadData2("Сколько человек в компании?");

//Записывает всех по именно в массив
string[] Gen1DArr(int AllFriends)
{
    string[] arr = new string[AllFriends];
    for (int i = 0; i < AllFriends; i++)
    {
        arr[i] = ReadData("Введите имя следующего человека") + " ";
    }

    return arr;
} 

//выбирает их массива человеекка
string Happy = Gen1DArr(AllFriends)[new Random().Next(0, AllFriends-1)];

//Выводит результат
Console.WriteLine($"За пивом бежит {Happy}");