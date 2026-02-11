static class Program
{
    static void Main()
    {
        List<string> list_string = new();
        PrintItem(list_string);
        list_string.Add("Mow lawn");
        list_string.Add("Pay taxes");
        PrintItem(list_string);
        bool removed = list_string.Remove("Mow lawn");
        list_string.Add("Shopping");
        PrintItem(list_string);
    }
    static void PrintItem(List<string> list_string)
    {
        Console.WriteLine($"Amount of tasks: {list_string.Count}");
        foreach (var item in list_string)
        {
            Console.WriteLine(item);
        }
    }
}
