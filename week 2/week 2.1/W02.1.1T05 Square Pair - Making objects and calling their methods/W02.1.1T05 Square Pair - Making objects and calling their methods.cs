static class Program
{
    static void Main()
    {
        Square first = new(5);
        Square second = new(10);
        print(first);
        print(second);
    }
    public static void print(Square value)
    {
        Console.WriteLine($"Side: {value.Side}");
        Console.WriteLine($"Area: {value.GetArea()}");
        Console.WriteLine($"Perimeter: {value.GetPerimeter()}");
    }
}
