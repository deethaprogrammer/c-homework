static class Program
{
    static void Main()
    {
        Console.WriteLine("What is the month? 1-12");
        int Month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the day? 1-31");
        int Day = Convert.ToInt32(Console.ReadLine());
        int Date = Month * 100 + Day;
        string Season = Date switch
        {
            >= 321 and < 621 => "Spring",
            >= 621 and < 921 => "Summer",
            >= 921 and < 1221 => "Autumn",
            >= 1221 or < 321 => "Winter"
        };
        Console.WriteLine($"On {Day}-{Month} it is {Season}");
    }
}
