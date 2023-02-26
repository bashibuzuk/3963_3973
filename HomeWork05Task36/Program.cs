// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//* Найдите все пары в массиве и выведите пользователю


//генерация массива
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

// метод печати всех пар в массиве
void AllPairs (int[] array)
{
    
    int len = array.Length;
    
    for (int j = 0 ; j < len; j++)
        {int index = j;
        int Pairs = array[index];
        for (int i = index + 1; i < len; i++)
        {
            if (Pairs == array[i])
            {
                Console.WriteLine($"Пара для числа {Pairs} найдена  в индексе {index} и {i}");
                break; 
            }
        }    

        }
    
}

//метод печати массива
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}


int[] table = Gen1DArr(10, 1, 10);  //создаём массив
Print1DArr(table);                  //печатаем массив
AllPairs(table);                    //выводи все пары



// int SummOdds(int[] arr)
// {
//     int len = arr.Length;
//     int result = 0;
        
//     for (int i = 1; i < len; i = i + 2)
//     {
//         result = result + arr[i];
        
//     }

//     return result;
// }
