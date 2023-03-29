﻿// Задача №37
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.


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

void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int[] ConvertArr(int[] arr)
{
    int len = arr.Length;
    int[] mass = new int[len/2];
    
    for (int i = 0; i < len - 1; i++)
    {
        mass[i] = arr[i] * arr[len-1];
        len--;
    }

    return mass;
}

int[] mass = Gen1DArr(10, 1, 10);
Print1DArr(mass);

Print1DArr(ConvertArr(mass));