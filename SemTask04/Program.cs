string? lineN = Console.ReadLine();
if (lineN != null)
{
    int N = int.Parse(lineN);
    int N2 = N*(-1);
    string res = String.Empty;
    while (N2<=N)
    {
        res = res + N2 + " ";
        N2 = N2 + 1;
    }
Console.WriteLine(res);
}
