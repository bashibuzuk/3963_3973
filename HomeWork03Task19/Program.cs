
int ReadInput(string mess)
{
    Console.Write(mess);
    return int.Parse(Console.ReadLine()??"0");
}

bool PallTest(int Number)
{
    bool res = false;
    if ((Number/10000 == Number%10 ) && (Number/1000%10 == Number/10%10))
    {
        res = true;
        
    }
    return res;
}

int Numer = ReadInput("Введите пятизначное  число: ");
Console.WriteLine(PallTest(Numer));

