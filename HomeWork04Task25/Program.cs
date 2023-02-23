// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// *Написать калькулятор с операциями +, -, /, * и возведение в степень

//принимает на вход число
int ReadData(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Принимает на вход действие
string ReadData2(string message)
{
    Console.WriteLine(message);
    return (Console.ReadLine() ?? "0");
}

// метод Возведение в степень
int Stepen(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result*A;
    }
    return result;
}

//Метод Сумма
int Summa(int A, int B)
{
    
    int result = A + B;
    return result;
}

//Метогд Вычитание
int Minus(int A, int B)
{
    int result = A - B;
    return result;
}

//Метод Умножение
int Umnosheniye(int A, int B)
{
    int result = A * B;
    return result;
}

//Метод Деление
int Deleniye(int A, int B)
{
    int result = A / B;
    return result;
}

//метод Печать
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Метод Калькулятор
int Calculator(string Act, int NumberA, int NumberB)
{
    int result = 0;
    if (Act == "+") result = Summa(NumberA, NumberB);
    if (Act == "-") result = Minus(NumberA, NumberB);
    if (Act == "*") result = Umnosheniye(NumberA, NumberB);
    if (Act == "/") result = Deleniye(NumberA, NumberB);
    if (Act == "**") result = Stepen(NumberA, NumberB);
    return result;
}


int NumberA = ReadData("Введите число А: ");  //зажаём значение числа А
int NumberB = ReadData("Введите число В: ");  //зажаём значение числа В
string Acting = ReadData2("Выберите из представленного что будем делать? +; -; *; /; **; "); //Выбираем действие

PrintResult("Ответ: " + Calculator(Acting, NumberA, NumberB)); 
