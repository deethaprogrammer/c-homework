static class Program
{
    static void Main()
    {
        Random rng = new Random();
        for (int i = 1; i <= 10; i++)
        {
            int RandomNumber = rng.Next(1, 7);
            Console.WriteLine(RandomNumber);
        }
    }
}
