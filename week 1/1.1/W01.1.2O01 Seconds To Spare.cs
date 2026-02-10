static class Time_Calculator
{
    static void Main()
    {
        Console.WriteLine("How many seconds?");
        int seconds = Convert.ToInt32(Console.ReadLine());
        int Seconds_left = seconds % 60;
        int Minutes = (seconds % 3600) / 60;
        int Hours = seconds / 3600;
        Console.WriteLine("Hours: " + Hours);
        Console.WriteLine("Minutes: " + Minutes);
        Console.WriteLine("Seconds left: " + Seconds_left);
    }
}