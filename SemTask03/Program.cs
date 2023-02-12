string? lineDay = Console.ReadLine();
if (lineDay != null)
{
    int day = int.Parse(lineDay);
    string[] dayWeek = new string[7];
    dayWeek[0] = "Monday";
    dayWeek[1] = "Vtornik";
    dayWeek[2] = "Wendnesday";
    dayWeek[3] = "Thuesday";
    dayWeek[4] = "Friday";
    dayWeek[5] = "Saturday";
    dayWeek[6] = "Sunday";
    Console.WriteLine(dayWeek[day - 1]);
}