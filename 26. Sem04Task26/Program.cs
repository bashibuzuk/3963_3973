// Задача №26
// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.

string ReadInput(string mess)
{
    Console.Write(mess);
    return (Console.ReadLine()??"0");
}

void PrintData(string N)
{
    Console.WriteLine(N);
}


string num = (ReadInput("Введите число   ")).Length.ToString();


PrintData(num);