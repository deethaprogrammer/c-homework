static class Program
{
    static void Main()
    {
        int maxAttempts = 3;
        string pin = "1234";
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine("Enter your PIN");
            Console.WriteLine($"{i} attempts left");
            string password = Console.ReadLine();
            if (password == pin)
            {
                Console.WriteLine("Correct!");
                break;
            }
            else if (password != pin && i == 1)
            {
                Console.WriteLine("Your pass is confiscated.");
            }
        }

    }
}
