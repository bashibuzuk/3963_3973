// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// * Отсортировать массив методом пузырька
// * Отсортируйте массив методом подсчета

//генерация массива чисел
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
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

//Метод пузырька
void Selection(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        int len2 = array.Length - 1;
        for (int j = 0; j < len2; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temporary = array[j];
                array[j] = array[j+1];
                array[j+1] = temporary;
                    
            }
                
            
        }
    }  
}

// Метод Шелла
void ShellSort(int[] mass)
{
    int n = mass.Length;
    int i, j, step;
    int tmp;
    for (step = n / 2; step > 0; step /= 2)
        for (i = step; i < n; i++)
        {
            tmp = mass[i];
            for (j = i; j >= step; j -= step)
            {
                if (tmp < mass[j - step])
                    mass[j] = mass[j - step];
                else
                    break;
            }
            mass[j] = tmp;
        }
}

//Печать
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}


int[] table = Gen1DArr(10, 100, 999);                  //задаём переменную для массива
Print1DArr(table);                                     //печать массива
Console.WriteLine("Сортировка пузырьком");             
DateTime Time = DateTime.Now;                          // засекаем время 
Selection(table);                                         // сортировка
Console.WriteLine(DateTime.Now - Time);                // сколько времени прошло
Print1DArr(table);                                     // печать массива

Console.WriteLine("");
Console.WriteLine("Следующая сортировка");
int[] table2 = Gen1DArr(10, 100, 999);                 //назначаем переменную для массива
Print1DArr(table2);                                    //печать массива
Console.WriteLine("Сортировка методом Шелла");         
DateTime Time2 = DateTime.Now;                      // засекаем время
ShellSort(table2);                                    // сортировка
Console.WriteLine(DateTime.Now - Time2);            // сколько времени прошло
Print1DArr(table2);                                 // печать массива

