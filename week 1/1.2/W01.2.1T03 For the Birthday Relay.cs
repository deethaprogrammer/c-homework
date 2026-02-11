static class Program
{
    static void Main()
    {
        Console.WriteLine("What is the person's name?");
        string Name = Console.ReadLine();
        for(int i = 0; i < 4; i++)
        {
            if (i == 2)
            {
                Console.WriteLine($"Happy birthday dear {Name}!");
            }
            else
            {
                Console.WriteLine("Happy birthday to you!");
            }
        }
    }
}
