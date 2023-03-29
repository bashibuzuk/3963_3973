// Задача №32
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

//принимает на вход число

int[] Gen1DArr(int len, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max +1 );
    }

    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Метод для вывода данных
// void WriteMess(string mess)
// {
//     Console.WriteLine(mess);
// }

void InversArr(int[] arr)
{
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        arr[i] = arr[i]*-1;
    }
}


int[] mass = Gen1DArr(15, 1, 10);
Print1DArr(mass);
InversArr(mass);
Print1DArr(mass);