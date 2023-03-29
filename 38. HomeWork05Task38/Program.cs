// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// Отсортируйте массив методом вставки


// генерация массива
double[] Gen1DArr(int len, int num)
{


    Random rnd = new Random();
    double[] arr = new double[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.NextDouble()*num;
    }

    return arr;
}

// печать массива
void Print1DArr(double[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}


//сортировка методом выбора
static void Main(double[] arr)
{
    for(int i=1; i < arr.Length; i++)
    {
        double k = arr[i];
        int j = i - 1;

        while(j>=0 && arr[j] > k)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = k;
    }

}


double[] arr = Gen1DArr(10, 10);                //назначение переменной
Print1DArr(arr);                                //печать массива
Main(arr);                                      //сортировка выбором
Print1DArr(arr);                                //печать отсортированного массива
Console.WriteLine(arr[arr.Length- 1] - arr[0]); //печать разницы минимального и максимального значения


// получения разницы Максимального и Минимального числа
// double MinMax (double[] arr)
// {
//     double Min = double.MaxValue;
//     double Max = double.MinValue;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] > Max) Max = arr[i];
//         if (arr[i] < Min) Min = arr[i];
//     }
//     Console.WriteLine("Максимальное число " + Max);
//     Console.WriteLine("Минимальное число " + Min);
//     return Max - Min;

// }
