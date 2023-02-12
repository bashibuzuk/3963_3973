
Console.WriteLine("Введите первое первое число");
string? numLine1 = Console.ReadLine();
Console.WriteLine("Введите первое второе число");
string? numLine2 = Console.ReadLine();
if (numLine1 != null && numLine2 != null)
{ 
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    if (num1*num1 == num2)
    { 
        Console.WriteLine("Равен");
    }
    else 
    {
        Console.WriteLine("Не равен");
    }
}
