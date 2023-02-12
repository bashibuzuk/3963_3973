Console.WriteLine("Введите число ");
int Number  = Convert.ToInt32(Console.ReadLine());
if (Number%2 == 0)
{
    Console.WriteLine(Number + " - число четное");
}
else
{
    Console.WriteLine(Number + " - число нечетное");
}