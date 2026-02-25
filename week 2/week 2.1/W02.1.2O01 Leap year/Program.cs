public class Program
{
    public static void Main()
    {
        PrintIsLeapYear(1000);
        PrintIsLeapYear(1500);
        PrintIsLeapYear(2000);
        PrintIsLeapYear(2004);
        PrintIsLeapYear(2005);
    }

    public static int IsDivisibleBy(int dividend, int divisor)
    {
        return dividend % divisor;
    }

    public static bool IsLeapYear(int year)
    {
        if (IsDivisibleBy(year, 400) == 0 || IsDivisibleBy(year, 4) == 0 && IsDivisibleBy(year, 100) != 0)
        {
            return true;
        }
        return false;
    }

    public static void PrintIsLeapYear(int year)
    {
        Console.WriteLine(year + " " + (IsLeapYear(year) ? "is a leap year" : "is not a leap year"));
    }
}