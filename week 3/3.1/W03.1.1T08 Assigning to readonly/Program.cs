static class Program
{
    static void Main()
    {
        DatabaseManager dbm = new();

        Console.WriteLine($"Current connection: {dbm.Connection}");
    }
}
