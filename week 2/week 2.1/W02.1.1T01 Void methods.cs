static class program
{
    public static void Main()
    {
        PrintFullName("John", "Doe");
    }

    public static void PrintFullName(string FirstName, string LastName)
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}