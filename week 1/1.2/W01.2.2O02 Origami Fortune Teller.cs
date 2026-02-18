static class Program
{
    static void Main()
    {
        // V Your code goes below V
        bool TORF = true;
        string answer = "";
        int number = 0;
        do
        {
            Console.WriteLine("Pick a color (red/blue/green/yellow)");
            answer = Console.ReadLine();
            TORF = answer switch
            {
                "red" => false,
                "blue" => false,
                "green" => false,
                "yellow" => false,
                _ => true
            };
        }while(TORF);
        TORF = true;
        do
        {
            Console.WriteLine("pick a number (1-8)");
            number = Convert.ToInt32(Console.ReadLine());
        }while(number < 1 || number > 8);

        int fortuneNumber = (answer.Length + number) % 4 + 1;
        
        
        // ^ Your code goes above ^
        // No need to look below here for this assignment. But you are welcome to!
        string fortune = GetFortune(fortuneNumber);
        Console.WriteLine(fortune);
    }

    static string GetFortune(int fortuneNumber) => fortuneNumber switch
    {
        1 => "You will be loved and happy!",
        2 => "You will be loved and rich!",
        3 => "You will be loved and famous!",
        4 => "You will be loved, happy, rich, and famous!",
        _ => "Unknown. :( But you will still be loved, no matter what."
    };
}
