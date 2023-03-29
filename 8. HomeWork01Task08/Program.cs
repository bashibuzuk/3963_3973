Console.WriteLine("Введите число ");
int Number  = Convert.ToInt32(Console.ReadLine());
int index = 1;
string res = String.Empty;
while (index <= Number)
{
    if (index%2 == 0)
    {
        res = res + index + " ";
        index++;
    }
    else
    {
        index++;
    }

}

Console.WriteLine(res);