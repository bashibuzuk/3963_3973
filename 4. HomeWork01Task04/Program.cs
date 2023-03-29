Console.WriteLine("Введите число 1");
int Num_1  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int Num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int Num_3 = Convert.ToInt32(Console.ReadLine());

if (Num_1 > Num_2)
{
    if (Num_1 > Num_3)
    {
        Console.WriteLine("Самое большое число " + Num_1);
    }
    else
    {
        Console.WriteLine("Самое большое число " + Num_3);
    }
}
else
{
    if (Num_2 > Num_3)
    {
        Console.WriteLine("Самое большое число " + Num_2);
    }
    else
    {
        Console.WriteLine("Самое большое число " + Num_3);
    }
} 
